// (C) ASML 2022 Submitted for Interview assignment

using ASML.InterviewTest.Infra;

namespace ASML.InterviewTest.SumOfMultiple
{
    /// <summary>
    ///     Viewmodel for the SumOfMultiple class responsible for calling specific strategy using the input.
    /// </summary>
    public class ViewModel : ViewModelBase
    {
        private readonly SumOfMultiple _sumOfMultiple;
        private bool _isCalculateEnabled;
        private int? _limit;

        public ViewModel()
        {
            _limit = null;
            CalculateSum = new RelayCommand(OnCalculateSum, () => _isCalculateEnabled);
            _sumOfMultiple = new SumOfMultiple();
        }

        public string Limit
        {
            get => _limit == null ? string.Empty : _limit.ToString();
            set
            {
                var isValid = int.TryParse(value, out var data);

                if (isValid)
                {
                    _limit = data;
                    _isCalculateEnabled = true;
                }
                else if (string.IsNullOrEmpty(value))
                {
                    _limit = null;
                    _isCalculateEnabled = false;
                }

                OnPropertyChanged();
                CalculateSum.RaiseCanExecuteChangedEvent();
            }
        }

        public RelayCommand CalculateSum { get; }

        public string Sum { get; set; }

        private void OnCalculateSum()
        {
            if (!_limit.HasValue) return;

            var sum = _sumOfMultiple.ExecuteAlgorithm(_limit.Value);

            Sum = $"Sum is {sum:F0}";
            OnPropertyChanged(nameof(Sum));
        }
    }
}