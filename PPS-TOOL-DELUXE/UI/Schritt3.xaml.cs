using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step3 : Window
    {
        public Step3()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<Step3ViewModel>();
            if (viewModel.CloseAction == null)
                viewModel.CloseAction = Close;
            var nextWindow = new Step4();
            if (viewModel.ShowNextAction == null)
                viewModel.ShowNextAction = nextWindow.Show;
        }

        private void Schritt3_abbrechen_Copy_Click(object sender, RoutedEventArgs e)
        {
            var window = new Step4();
            window.Show();
            Close();
        }

        private void Schritt3_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void Schritt3_ContentRendered(object sender, System.EventArgs e)
        {
            var viewModel = ServiceLocator.Current.GetInstance<Step3ViewModel>();
            viewModel.Initialize();
        }
    }
}
