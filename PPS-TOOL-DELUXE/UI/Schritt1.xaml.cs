using System;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step1 : Window
    {
        public Step1()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<Step1ViewModel>();
            if (viewModel.CloseAction == null)
                viewModel.CloseAction = Close;
            var nextWindow = new Step2();
            if (viewModel.ShowNextAction == null)
                viewModel.ShowNextAction = nextWindow.Show;
        }

        private void Schritt2_Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            var window = new Dashboard();
            window.Show();
            Close();
        }
    }
}
