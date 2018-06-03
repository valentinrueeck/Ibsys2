using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step5 : Window
    {
        public Step5()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<Step5ViewModel>();
            if (viewModel.CloseAction == null)
                viewModel.CloseAction = Close;
        }

        private void Schritt5_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void Schritt5_ContentRendered(object sender, System.EventArgs e)
        {
            var viewModel = ServiceLocator.Current.GetInstance<Step5ViewModel>();
            viewModel.Initialize();
        }
    }
}
