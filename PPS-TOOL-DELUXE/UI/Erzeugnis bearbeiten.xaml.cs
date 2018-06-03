using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.Utility
{
    public partial class ErzeugnisBearbeiten : Window
    {
        private ProducesViewModel _viewModel;
        public ErzeugnisBearbeiten()
        {
            InitializeComponent();
            _viewModel = DataContext as ProducesViewModel;
        }

        private void btn_speichern_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveClick();
        }

        private void produceWorkspacesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (produceWorkspacesGrid.SelectedIndex == -1)
            {
                btn_minus.IsEnabled = false;
                return;
            }
            btn_minus.IsEnabled = true;
        }

        private void produceComponentGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (produceComponentGrid.SelectedIndex == -1)
            {
                btn_minus_Subkomponente.IsEnabled = false;
                return;
            }
            btn_minus_Subkomponente.IsEnabled = true;
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.DeleteWorkplaceClick();
            produceWorkspacesGrid.ItemsSource = _viewModel.SelectedProduce.timePerWorkplace;
            produceWorkspacesGrid.SelectedIndex = -1;
        }

        private void btn_minus_Subkomponente_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.DeleteComponentClick();
            produceComponentGrid.ItemsSource = _viewModel.SelectedProduce.subComponentList;
            produceComponentGrid.SelectedIndex = -1;
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.AddWorkspaceClick();
            produceWorkspacesGrid.ItemsSource = _viewModel.SelectedProduce.timePerWorkplace;
        }

        private void btn_plus_Subkomponente_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.AddSubComponentClick();
            produceComponentGrid.ItemsSource = _viewModel.SelectedProduce.subComponentList;
        }
    }
}
