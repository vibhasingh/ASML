// (C) ASML 2022 Submitted for Interview assignment

using System;
using System.Windows.Input;

namespace ASML.InterviewTest.Infra
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _canAct;

        public RelayCommand(Action action, Func<bool> canAct = null)
        {
            _action = action;
            _canAct = canAct;
        }

        protected RelayCommand(Func<bool> canAct = null)
        {
            _canAct = canAct;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecute();
        }

        public event EventHandler CanExecuteChanged;

        public virtual void Execute(object parameter)
        {
            Execute();
        }

        public void RaiseCanExecuteChangedEvent()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        protected virtual bool CanExecute()
        {
            return _canAct == null || _canAct();
        }

        protected virtual void Execute()
        {
            _action?.Invoke();
        }
    }
}