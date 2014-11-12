using System;
using System.Windows.Input;

namespace DemoMVVMPersonUdenNotification.viewmodel
{
    public class RelayCommand : ICommand
    {
        private Action _handler;
        public RelayCommand(Action handler)
        {
            _handler = handler;
            _isEnabled = true;
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (value != _isEnabled)
                {
                    _isEnabled = value;
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _handler();
        }
    }

}
