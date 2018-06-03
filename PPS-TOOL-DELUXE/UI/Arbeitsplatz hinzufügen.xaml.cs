using System.Windows;

namespace PPS_TOOL_DELUXE.Masterdata.Workplaces.UI
{
    public partial class ArbeitsplatzHinzufügen : Window
    {
        public ArbeitsplatzHinzufügen()
        {
            InitializeComponent();
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