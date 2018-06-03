using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.Utility
{
    public partial class KaufteilBearbeiten : Window
    {
        private PurchasesViewModel _viewModel;
        public KaufteilBearbeiten()
        {
            InitializeComponent();
            _viewModel = DataContext as PurchasesViewModel;
        }

        private void btn_speichern_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveClick();
        }
    }
}
