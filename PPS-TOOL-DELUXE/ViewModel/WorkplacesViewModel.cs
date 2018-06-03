using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PPS_TOOL_DELUXE.Model.MasterData.Workspaces;
using PPS_TOOL_DELUXE.UI;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class WorkplacesViewModel : ViewModelBase
    {
#region close window
        public RelayCommand<Window> CloseWindowCommand { get; private set; }

        private void CloseWindow(Window window)
        {
            var workplaces = WorkspacesModel.GetInstance().GetWorkspaces().ToList();
            Workspaces = new ObservableCollection<workspacesWorkspace>(workplaces);
            window?.Close();
        }
#endregion
        private ObservableCollection<workspacesWorkspace> _workspaces;
        public ObservableCollection<workspacesWorkspace> Workspaces
        {
            get => _workspaces;
            set
            {
                _workspaces = value;
                RaisePropertyChanged();
            }
        }

        private workspacesWorkspace _selectedWorkspace;
        public workspacesWorkspace SelectedWorkspace
        {
            get => _selectedWorkspace;
            set
            {
                _selectedWorkspace = value;
                RaisePropertyChanged();
            }
        }

        public WorkplacesViewModel()
        {
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);
            Workspaces = new ObservableCollection<workspacesWorkspace>(WorkspacesModel.GetInstance().GetWorkspaces());
        }

        internal void EditClick()
        {
            var dialog = new ArbeitsplatzBearbeiten {DataContext = this};
            dialog.ShowDialog();
        }

        public void SaveClick()
        {
            var model = WorkspacesModel.GetInstance();
            var newWorkspaces = _workspaces.ToArray();
            var workspaces = new workspaces {workspace = newWorkspaces};
            model.Workspaces = workspaces;
            model.SaveXmlFile();
        }
    }
}
