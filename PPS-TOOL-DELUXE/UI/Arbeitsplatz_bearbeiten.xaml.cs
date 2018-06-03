using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class ArbeitsplatzBearbeiten : Window
    {
        private WorkplacesViewModel _viewModel;
        public ArbeitsplatzBearbeiten()
        {
            InitializeComponent();
            _viewModel = DataContext as WorkplacesViewModel;
        }

        private void btn_speichern_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveClick();
        }
    }
}
