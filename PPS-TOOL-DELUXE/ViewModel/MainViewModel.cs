using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Annotations;
using PPS_TOOL_DELUXE.Model.Output;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ExportModel export;

        private results LastPeriod { get; set; }

        public MainViewModel()
        {
            export = new ExportModel();
            LastPeriod = ServiceLocator.Current.GetInstance<DashboardViewModel>().LastPeriod;
        }
    }
}