// (C) ASML 2022 Submitted for Interview Test Assignment

using System.Windows.Input;
using ASML.InterviewTest.Infra;

namespace ASML.InterviewTest.Runner
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

        public ViewModelBase SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }
    }
}
