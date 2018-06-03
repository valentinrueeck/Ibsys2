using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PPS_TOOL_DELUXE.Masterdata.Workplaces.UI;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.MasterData.Workspaces;
using PPS_TOOL_DELUXE.Utility;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class ProducesViewModel : ViewModelBase
    {
        #region close window
        public RelayCommand<Window> CloseWindowCommand { get; private set; }

        private void CloseWindow(Window window)
        {
            var produces = ProduceItemsModel.GetInstance().GetProduceItems().ToList();
            Produces = new ObservableCollection<produceItemsItem>(produces);
            window?.Close();
        }
        #endregion
        private ObservableCollection<produceItemsItem> _produces;
        public ObservableCollection<produceItemsItem> Produces
        {
            get => _produces;
            set
            {
                _produces = value;
                RaisePropertyChanged();
            }
        }

        private produceItemsItem _selectedProduce;
        public produceItemsItem SelectedProduce
        {
            get => _selectedProduce;
            set
            {
                _selectedProduce = value;
                RaisePropertyChanged();
            }
        }

        private produceItemsItemWorkplace _selectedProduceWorkspace;
        public produceItemsItemWorkplace SelectedProduceWorkspace
        {
            get => _selectedProduceWorkspace;
            set
            {
                _selectedProduceWorkspace = value;
                RaisePropertyChanged();
            }
        }

        private produceItemsItemSubComponent _selectedProduceSubcomponent;
        public produceItemsItemSubComponent SelectedProduceSubcomponent
        {
            get => _selectedProduceSubcomponent;
            set
            {
                _selectedProduceSubcomponent = value;
                RaisePropertyChanged();
            }
        }

        private produceItemsItemWorkplace _newProduceWorkspace = new produceItemsItemWorkplace();
        public produceItemsItemWorkplace NewProduceWorkspace
        {
            get => _newProduceWorkspace;
            set
            {
                _newProduceWorkspace = value;
                RaisePropertyChanged();
            }
        }

        private produceItemsItemSubComponent _newProduceSubcomponent = new produceItemsItemSubComponent();
        public produceItemsItemSubComponent NewProduceSubcomponent
        {
            get => _newProduceSubcomponent;
            set
            {
                _newProduceSubcomponent = value;
                RaisePropertyChanged();
            }
        }

        public ProducesViewModel()
        {
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);
            AddWorkspaceCommand = new RelayCommand(AddWorkSpaceToProduce);
            AddComponentCommand = new RelayCommand(AddSubComponentProduce);
            Produces = new ObservableCollection<produceItemsItem>(ProduceItemsModel.GetInstance().GetProduceItems());
        }

        public void EditClick()
        {
            var dialog = new ErzeugnisBearbeiten { DataContext = this };
            dialog.ShowDialog();
        }

        public void SaveClick()
        {
            var model = ProduceItemsModel.GetInstance();
            var newProduces = _produces.ToArray();
            var produces = new produceItems { item = newProduces };
            model.Produces = produces;
            model.SaveXmlFile();
        }

        public void DeleteWorkplaceClick()
        {
            SelectedProduce.timePerWorkplace =
                SelectedProduce.timePerWorkplace.Where(w => w != SelectedProduceWorkspace).ToArray();
        }

        public void DeleteComponentClick()
        {
            SelectedProduce.subComponentList =
                SelectedProduce.subComponentList.Where(w => w != SelectedProduceSubcomponent).ToArray();
        }

        public void AddWorkspaceClick()
        {
            var dialog = new ArbeitsplatzHinzufügen { DataContext = this };
            dialog.ShowDialog();
        }

        public void AddSubComponentClick()
        {
            var dialog = new SubkomponenteHinzufügen() { DataContext = this };
            dialog.ShowDialog();
        }

        public RelayCommand AddWorkspaceCommand { get; private set; }

        public void AddWorkSpaceToProduce()
        {
            var newWorkspaces = _selectedProduce.timePerWorkplace?.ToList() ?? new List<produceItemsItemWorkplace>();
            newWorkspaces.Add(_newProduceWorkspace);
            _selectedProduce.timePerWorkplace = newWorkspaces.ToArray();
        }

        public RelayCommand AddComponentCommand { get; private set; }

        public void AddSubComponentProduce()
        {
            _newProduceSubcomponent.typ = "P";
            var newComponents = _selectedProduce.subComponentList?.ToList() ?? new List<produceItemsItemSubComponent>();
            newComponents.Add(_newProduceSubcomponent);
            _selectedProduce.subComponentList = newComponents.ToArray();
        }
    }
}
