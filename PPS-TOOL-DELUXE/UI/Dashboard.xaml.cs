using System.Globalization;
using System.Windows;
using System.Windows.Input;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Dashboard
    {
        private readonly DashboardViewModel _viewModel;
        public Dashboard()
        {
            InitializeComponent();
            _viewModel = DataContext as DashboardViewModel;
        }

        private void btn_Periode_importieren_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ImportPeriodClick();
            GridPeriods.Items.Refresh();
        }

        private void btn_Periode_planen_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.PlanPeriodClick();
            Close();
        }

        private void btn_Arbeitsplätze_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.WorkspacesClick();
        }

        private void btn_Erzeugnisse_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ProduceItemsClick();
        }

        private void btn_Kaufteile_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.PurchaseItemsClick();
        }

        private void BtnGerman_Click(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("de");
            CommandManager.InvalidateRequerySuggested();
        }

        private void BtnEnglish_Click(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("en-GB");
            CommandManager.InvalidateRequerySuggested();
        }

        private void BtnFrench_Click(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("fr-FR");
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
