/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:PPS_TOOL_DELUXE"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<DashboardViewModel>();
            SimpleIoc.Default.Register<WorkplacesViewModel>();
            SimpleIoc.Default.Register<PurchasesViewModel>();
            SimpleIoc.Default.Register<ProducesViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Step1ViewModel>();
            SimpleIoc.Default.Register<Step2ViewModel>();
            SimpleIoc.Default.Register<Step3ViewModel>();
            SimpleIoc.Default.Register<Step4ViewModel>();
            SimpleIoc.Default.Register<Step5ViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public DashboardViewModel Dashboard
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DashboardViewModel>();
            }
        }

        public WorkplacesViewModel Workplaces
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WorkplacesViewModel>();
            }
        }

        public PurchasesViewModel Purchases
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PurchasesViewModel>();
            }
        }

        public ProducesViewModel Produces
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProducesViewModel>();
            }
        }

        public Step1ViewModel Step1
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Step1ViewModel>();
            }
        }
        public Step2ViewModel Step2
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Step2ViewModel>();
            }
        }
        public Step3ViewModel Step3
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Step3ViewModel>();
            }
        }
        public Step4ViewModel Step4
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Step4ViewModel>();
            }
        }
        public Step5ViewModel Step5
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Step5ViewModel>();
            }
        }

        public static void Cleanup()
        {
            //TODO Clear the ViewModels
        }
    }
}