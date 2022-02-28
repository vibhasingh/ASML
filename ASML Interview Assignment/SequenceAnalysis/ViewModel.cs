// (C) ASML 2022 Submitted for Interview assignment

using ASML.InterviewTest.Infra;
using ASML.InterviewTest.ProblemStrategy;

namespace ASML.InterviewTest.SequenceAnalysis
{
    /// <summary>
    ///     Viewmodel for the SequenceAnalysis class responsible for calling specific strategy using the input.
    /// </summary>
    public class ViewModel : ViewModelBase
    {
        private string _input;
        private bool _isAnalysisEnabled;

        public ViewModel()
        {
            Analyze = new RelayCommand(OnAnalysis, () => _isAnalysisEnabled);
        }

        public string Input
        {
            get => _input;
            set
            {
                _input = value;

                _isAnalysisEnabled = !string.IsNullOrEmpty(_input);

                OnPropertyChanged();
                Analyze.RaiseCanExecuteChangedEvent();
            }
        }

        public RelayCommand Analyze { get; }

        public string Output { get; set; }

        private void OnAnalysis()
        {
            var context = new ProblemContext();
            context.SetStrategy(new SequenceAnalysis());
            var output = context.ExecuteStrategy(_input);

            Output = string.IsNullOrEmpty((string) output) ? "Upper case words not available" : $"Output is {output}";
            OnPropertyChanged(nameof(Output));
        }
    }
}