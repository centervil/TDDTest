using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TDDTest.Core.Helpers
{
    public sealed class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public DelegateCommand(Action execute) : this(execute, () => true)
        {
        }
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute()
        {
            return _canExecute();
        }

        public void Execute()
        {
            _execute();
        }

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                return;
            }
            remove
            {
                return;
            }
        }

        #region ICommand
        /// <inheritdoc/>
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }
        /// <inheritdoc/>
        void ICommand.Execute(object parameter)
        {
            Execute();
        }
        #endregion
    }
}
