using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Win32;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.MasterData.Workspaces;
using PPS_TOOL_DELUXE.Model.Output;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class Step5ViewModel : ViewModelBase
    {
        public Action CloseAction { get; set; }
        public Action ExportAction { get; set; }

        private results rLastPeriod;
        private ExportModel exportModel;

        private List<Production> productionList;
        private List<produceItemsItem> produceItemProductionList;
        private List<workspacesWorkspace> workspaces;
        private List<produceItemsItem> produceItems;
        public ObservableCollection<WorkplaceTimeModel> WorkplacesTimesNew { get; set; }
        public ObservableCollection<int> LayersList { get; } = new ObservableCollection<int> {1, 2, 3};

        public Step5ViewModel()
        {
            NextCommand = new RelayCommand(NextClick);
        }

        public void Initialize()
        {
            exportModel = ServiceLocator.Current.GetInstance<MainViewModel>().export;
            rLastPeriod = ServiceLocator.Current.GetInstance<DashboardViewModel>().LastPeriod;

            productionList = exportModel.productionList;

            produceItemProductionList = new List<produceItemsItem>();
            WorkplacesTimesNew = new ObservableCollection<WorkplaceTimeModel>();

            workspaces = WorkspacesModel.GetInstance().GetWorkspaces();
            produceItems = ProduceItemsModel.GetInstance().GetProduceItems();

            produceItemProductionList = ProduceItemsModel.GetInstance().GetProduceItems();

            workspaces.ForEach(w =>
            {
                string description = w.label.de;
                var shift = 1;
                var model = new WorkplaceTimeModel(w.id, description, 0, 0, 0, 0, 0, shift, 0);
                WorkplacesTimesNew.Add(model);
            });

            calcSetUpNew();

            productionList.ForEach(i => calculateProductionTimeNew(i.article, i.quantity));

            createMapOldTimeOrdersInWork(rLastPeriod);

            createMapOldWaitinglistWorkstations(rLastPeriod);

            oldSetUpTime(rLastPeriod, produceItems);

            calculate();
        }

        private void calcSetUpNew()
        {
            productionList.ForEach(list =>
            {
                produceItems.ForEach(item =>
                {
                    if (item.id == list.article)
                    {
                        item.timePerWorkplace.ToList().ForEach(work =>
                        {
                            WorkplacesTimesNew.ToList().ForEach(workNew =>
                            {
                                if (workNew.Id != work.id) return;
                                if (list.quantity > 0)
                                    workNew.SetUpNew += work.setUpTime;
                            });
                        });
                    }
                });
            });
        }

        private void calculateProductionTimeNew(int item, int quantity)
        {
            produceItemProductionList.ForEach(k => 
            {
                if (k.id == item)
                {
                    k.timePerWorkplace.ToList().ForEach((j => 
                    {
                        WorkplacesTimesNew.ToList().ForEach(x => 
                        {
                            if (x.Id == j.id)
                            {
                                x.KapaNew += j.time * quantity;
                            }
                        });
                    }));
                }
            });
        }

        private void createMapOldTimeOrdersInWork(results rLastPeriod)
        {
            rLastPeriod.ordersinwork.ToList().ForEach(work => 
            {
                WorkplacesTimesNew.ToList().ForEach(workNew => 
                {
                    if (workNew.Id == work.id)
                    {
                        workNew.KapaOld += work.timeneed;
                    }
                });
            });
        }

        private void createMapOldWaitinglistWorkstations(results rLastPeriod)
        {
            rLastPeriod.waitinglistworkstations?.ToList().ForEach(wait => 
            {
                WorkplacesTimesNew.ToList().ForEach(workNew => 
                {
                    if (workNew.Id == wait.id)
                    {
                        workNew.KapaOld += wait.timeneed;
                    }
                });
            });
        }

        private void oldSetUpTime(results rLastPeriod, List<produceItemsItem> produceItems)
        {
            var itemsList = new List<int>();

            rLastPeriod.waitinglistworkstations?.ToList().ForEach(wait =>
            {
                wait.waitinglist?.ToList().ForEach(waitList=> 
                {
                    itemsList.Add(waitList.item);
                });
            });

            itemsList.ForEach(item => 
            {
                produceItems.ForEach(produce =>
                {
                    if (item == produce.id)
                    {
                        produce.timePerWorkplace.ToList().ForEach(work => 
                        {
                            WorkplacesTimesNew.ToList().ForEach(workNew => 
                            {
                                if (workNew.Id == work.id)
                                {
                                    workNew.SetUpOld += work.setUpTime;
                                }
                            });
                        });
                    }
                });
            });
        }

        private void calculate()
        {
            WorkplacesTimesNew.ToList().ForEach(i => 
            {
                i.Total = i.KapaNew + i.KapaOld + i.SetUpNew + i.SetUpOld;

                //schichten eintragen
                if (i.Total > 5900)
                {          //-100 wegen Puffer
                    i.Shifts = 3;
                }
                else if (i.Total > 3500)
                {   //-100 wegen Puffer
                    i.Shifts = 2;
                }
                else
                {
                    i.Shifts = 1;
                }

                // Überstunden eintragen
                if ((i.Total - (i.Shifts - 1) * 2400) > 2400)
                {
                    i.Overtime = (i.Total + 100 - (i.Shifts * 2400)) / 5;
                }
                if (i.Shifts == 3)
                {
                    i.Overtime = 0;
                }
            });
        }

        public RelayCommand NextCommand { get; set; }
        public void NextClick()
        {
            AddEverythingToExportModel();
            ServiceLocator.Current.GetInstance<MainViewModel>().export = exportModel;

            var periodNr = rLastPeriod.period;
            var path = AppDomain.CurrentDomain.BaseDirectory + @"simulations\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var dialog = new SaveFileDialog
            {
                Filter = "XML (*.xml)|*.xml",
                Title = "XML Export",
                FileName = $"InputPeriod{periodNr+1}.xml",
                InitialDirectory = path
            };
            if (dialog.ShowDialog() == true)
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("\t");
                settings.OmitXmlDeclaration = true;
                var xmlWriter = XmlWriter.Create(dialog.FileName, settings);
                var serializer = new XmlSerializer(typeof(ExportModel));
                serializer.Serialize(xmlWriter, exportModel, ns);

                xmlWriter.Flush();
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
        }

        private void AddEverythingToExportModel()
        {
            var workingtimeList = new List<Workingtime>();
            Workingtime newWorkingtime;

            WorkplacesTimesNew.ToList().ForEach(w =>
            {
                newWorkingtime = new Workingtime(w.Id, w.Shifts > 3 ? 3 : w.Shifts, w.Overtime);
                workingtimeList.Add(newWorkingtime);
            });

            exportModel.workingtimeList = workingtimeList;
        }
    }
}
