using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PPS_TOOL_DELUXE.Model.MasterData.PurchaseItems;
using PPS_TOOL_DELUXE.Utility;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class PurchasesViewModel : ViewModelBase
    {
        #region close window
        public RelayCommand<Window> CloseWindowCommand { get; private set; }

        private void CloseWindow(Window window)
        {
            var purchases = PurchaseItemsModel.GetInstance().GetPurchaseItems().ToList();
            Purchases = new ObservableCollection<purchaseItemsItem>(purchases);
            window?.Close();
        }
        #endregion
        private ObservableCollection<purchaseItemsItem> _purchases;
        public ObservableCollection<purchaseItemsItem> Purchases
        {
            get => _purchases;
            set
            {
                _purchases = value;
                RaisePropertyChanged();
            }
        }

        private purchaseItemsItem _selectedPurchase;
        public purchaseItemsItem SelectedPurchase
        {
            get => _selectedPurchase;
            set
            {
                _selectedPurchase = value;
                RaisePropertyChanged();
            }
        }

        public PurchasesViewModel()
        {
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);
            Purchases = new ObservableCollection<purchaseItemsItem>(PurchaseItemsModel.GetInstance().GetPurchaseItems());
        }

        public void EditClick()
        {
            var dialog = new KaufteilBearbeiten { DataContext = this };
            dialog.ShowDialog();
        }

        public void SaveClick()
        {
            var model = PurchaseItemsModel.GetInstance();
            var newPurchases = _purchases.ToArray();
            var purchases = new purchaseItems { item = newPurchases };
            model.Purchases = purchases;
            model.SaveXmlFile();
        }
    }
}
