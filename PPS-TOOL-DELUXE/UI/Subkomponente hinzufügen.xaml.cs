using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.Utility
{
    public partial class SubkomponenteHinzufügen : Window
    {
        private ProducesViewModel _viewModel;
        public SubkomponenteHinzufügen()
        {
            InitializeComponent();
            _viewModel = DataContext as ProducesViewModel;
        }

        private void btn_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
