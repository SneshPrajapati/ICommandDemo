using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RxPropertyAndCommand.Commands
{
    public class RelayCommand<T> : ICommand
    {
        private Action<T> commandTask;

        public RelayCommand(Action<T> workToDo)
        {
            commandTask = workToDo;
        }

      

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        private Action action;

        public void Execute(object parameter)
        {
           T param = (T)parameter;

            commandTask(param);
        }
    }
}
