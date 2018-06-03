using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.Utility
{
    public partial class Erzeugnisverwaltung : Window
    {
        private ProducesViewModel _viewModel;
        public Erzeugnisverwaltung()
        {
            InitializeComponent();
            _viewModel = DataContext as ProducesViewModel;
        }

        private void producesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (producesGrid.SelectedIndex == -1)
            {
                btn_bearbeiten.IsEnabled = false;
                return;
            }
            btn_bearbeiten.IsEnabled = true;
        }

        private void btn_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.EditClick();
        }
    }
}
