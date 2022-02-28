// (C) ASML 2022 Submitted for Interview Test Assignment

using ASML.InterviewTest.Infra;
using ASML.InterviewTest.SequenceAnalysis;

namespace ASML.InterviewTest.Runner
{
    /// <summary>
    ///     Class to update the view based on selected problem type
    /// </summary>
    public class UpdateViewCommand : RelayCommand
    {
        private readonly ViewModel _sequenceViewModel;
        private readonly SumOfMultiple.ViewModel _sumOfMultipleViewModel;
        private readonly MainViewModel _viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
            _sumOfMultipleViewModel = new SumOfMultiple.ViewModel();
            _sequenceViewModel = new ViewModel();
        }

        /// <summary>
        ///     Based on selected problem tag respective view model is bound to Content control
        /// </summary>
        /// <param name="parameter">The tag of selected problem from button click</param>
        public override void Execute(object parameter)
        {
            var problemName = parameter.ToString();

            switch (problemName)
            {
                case "SumOfMultiple":
                    _viewModel.SelectedViewModel = _sumOfMultipleViewModel;
                    break;
                case "SequenceAnalysis":
                    _viewModel.SelectedViewModel = _sequenceViewModel;
                    break;
            }
        }
    }
}