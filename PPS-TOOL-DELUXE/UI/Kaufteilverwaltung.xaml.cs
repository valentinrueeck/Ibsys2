using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Kaufteilverwaltung : Window
    {
        private PurchasesViewModel _viewModel;
        public Kaufteilverwaltung()
        {
            InitializeComponent();
            _viewModel = DataContext as PurchasesViewModel;
        }

        private void purchasesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (purchasesGrid.SelectedIndex == -1)
            {
                btn_Kaufteilverwaltung_bearbeiten.IsEnabled = false;
                return;
            }
            btn_Kaufteilverwaltung_bearbeiten.IsEnabled = true;
        }

        private void btn_Kaufteilverwaltung_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.EditClick();
        }
    }
}
