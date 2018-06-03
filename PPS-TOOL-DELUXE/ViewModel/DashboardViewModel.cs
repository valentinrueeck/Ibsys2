using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using GalaSoft.MvvmLight;
using Microsoft.Win32;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.UI;
using PPS_TOOL_DELUXE.Utility;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class DashboardViewModel : ViewModelBase
    {

        private CultureInfo CurrentLanguage { get; set; }

        private ObservableCollection<Period> _periods = new ObservableCollection<Period>();
        public ObservableCollection<Period> Periods
        {
            get => _periods;
            set
            {
                _periods = value;
                RaisePropertyChanged();
            }
        }

        public results LastPeriod { get; set; }

        private bool _canPlan;
        public bool CanPlan
        {
            get => _canPlan;
            set
            {
                _canPlan = value;
                RaisePropertyChanged();
            }
        }
        
        public DashboardViewModel()
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            Periods.Clear();
            LoadXmlInputs();
            CanPlan = Periods.Count > 0;
        }

        private void LoadXmlInputs()
        {
            var resultsPath = "./results/";
            if (!Directory.Exists(resultsPath))
                Directory.CreateDirectory(resultsPath);

            var files = Directory.GetFiles(resultsPath);
            files.ToList().ForEach(path =>
            {
                if (File.Exists(path))
                    LoadXmlInput(path);
            });

            //Periods = new ObservableCollection<Period>(Periods.OrderByDescending(p => p.Id).ToList());//TODO handle duplicate ids
        }

        private void LoadXmlInput(string path)
        {
            var settings = new XmlReaderSettings();
            var xmlReader = XmlReader.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(results));
            var result = (results)serializer.Deserialize(xmlReader);
            xmlReader.Close();
            var p = new Period
            {
                Id = result.period,
                Efficiency = result.result.general.effiency.current,
                Profit = result.result.summary.profit.current,
                Totalprofit = result.result.summary.profit.all,
                Workload = result.result.general.relpossiblenormalcapacity.current
            };
            Periods.Add(p);

            if (LastPeriod == null || LastPeriod.period < result.period)
                LastPeriod = result;
        }

        public void WorkspacesClick()
        {
            var workspacesWindow = new Arbeitsplatzverwaltung();
            workspacesWindow.ShowDialog();
        }

        public void ImportPeriodClick()
        {
            var dialog = new OpenFileDialog
            {
                Filter = "XML (*.xml)|*.xml",
                Title = "XML Import"
            };
            var fileOpened = dialog.ShowDialog();

            if (fileOpened.GetValueOrDefault() && File.Exists(dialog.FileName))
            {
                var settings = new XmlReaderSettings();
                var xmlReader = XmlReader.Create(dialog.FileName, settings);
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(results));
                var result = (results)serializer.Deserialize(xmlReader);
                xmlReader.Close();

                var periodExists = false;
                foreach (var period in Periods)
                {
                    if (period.Id == result.period) periodExists = true;
                }

                if (periodExists)
                {
                    MessageBox.Show($"Period #{result.period} already exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

                var path = "./results/period" + result.period + ".xml";

                var settingsWriter = new XmlWriterSettings();
                var xmlWriter = XmlWriter.Create(path, settingsWriter);
                serializer.Serialize(xmlWriter, result);
                xmlWriter.Close();

                LoadDashboard();
            }
        }

        public void PlanPeriodClick()
        {
            var window = new Step1();
            window.Show();
        }

        public void ProduceItemsClick()
        {
            var producesWindow = new Erzeugnisverwaltung();
            producesWindow.ShowDialog();
        }

        public void PurchaseItemsClick()
        {
            var purchasesWindow = new Kaufteilverwaltung();
            purchasesWindow.ShowDialog();
        }

        public void FlagDeClick() => ReloadDashboard(new CultureInfo("de"));

        public void FlagEnClick() => ReloadDashboard(new CultureInfo("en"));

        public void FlagFrClick() => ReloadDashboard(new CultureInfo("fr"));

        private void ReloadDashboard(CultureInfo locale)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                locale;
            //TODO reload
            throw new NotImplementedException();
        }
    }
}
