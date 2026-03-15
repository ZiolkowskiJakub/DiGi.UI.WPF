using System.Windows.Input;

namespace DiGi.UI.WPF.Classes
{
    public class ToggleCommand : ICommand
    {
        private readonly Action<object?> execute;

        public ToggleCommand(Action<object?> execute)
        {
            this.execute = execute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}