using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.Output;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class Step4ViewModel : ViewModelBase
    {
        public Action CloseAction { get; set; }
        public Action ShowNextAction { get; set; }

        private ExportModel exportModel;

        public ObservableCollection<ProductionOrderModel> ProduceItemsAll { get; } =
            new ObservableCollection<ProductionOrderModel>();

        public ProductionOrderModel SelectedRow { get; set; }

        public ObservableCollection<int> ProduceItemIds { get; set; }

        public Step4ViewModel()
        {
            NextCommand = new RelayCommand(NextClick);
            AddRowCommand = new RelayCommand(AddRow);
            DeleteRowCommand = new RelayCommand(DeleteRow);
        }

        private void AddRow()
        {
            ProduceItemsAll.Add(new ProductionOrderModel(ProduceItemIds.ToList(), 1, 0));
        }
        private void DeleteRow()
        { 
            ProduceItemsAll.Remove(SelectedRow);
        }

        public RelayCommand NextCommand { get; set; }
        public RelayCommand AddRowCommand { get; set; }
        public RelayCommand DeleteRowCommand { get; set; }

        private void NextClick()
        {
            AddEverythingToExportModel();
            ServiceLocator.Current.GetInstance<MainViewModel>().export = exportModel;
            CloseAction();
            ShowNextAction();
        }

        private void AddEverythingToExportModel()
        {
            var productionList = new List<Production>();
            ProduceItemsAll.ToList().Where(item=> item.Number > 0).ToList().ForEach(item =>
            {
                productionList.Add(new Production(item.SelectedItem, item.Number));
            });
            exportModel.productionList = productionList;
        }

        public void Initialize()
        {
            exportModel = ServiceLocator.Current.GetInstance<MainViewModel>().export;

            var allProduceItems = ProduceItemsModel.GetInstance().GetProduceItems();
            ProduceItemIds = new ObservableCollection<int>(allProduceItems.Select(p => p.id));

            var listOfIds = ProduceItemIds.ToList();
            exportModel.productionList.ForEach(item =>
            {
                ProduceItemsAll.Add(new ProductionOrderModel(new List<int>(listOfIds), item.article, item.quantity));
            });

        }
    }
}
