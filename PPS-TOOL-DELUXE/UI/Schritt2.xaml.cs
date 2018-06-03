using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step2 : Window
    {
        public Step2()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<Step2ViewModel>();
            if (viewModel.CloseAction == null)
                viewModel.CloseAction = Close;
            var nextWindow = new Step3();
            if (viewModel.ShowNextAction == null)
                viewModel.ShowNextAction = nextWindow.Show;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Dashboard();
            window.Show();
            Close();
        }

        private void Schritt2_Weiter_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Schritt2_ContentRendered(object sender, System.EventArgs e)
        {
            var viewModel = ServiceLocator.Current.GetInstance<Step2ViewModel>();
            viewModel.Intialize();
        }
    }
}
