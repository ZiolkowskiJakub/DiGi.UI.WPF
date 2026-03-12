using System.Windows.Input;

namespace DiGi.UI.WPF.Core.Classes
{
    public class ToggleCommandAsync : ICommand
    {
        private readonly Func<object?, Task> execute;
        private readonly Predicate<object?>? canExecute;
        private bool isExecuting;

        public ToggleCommandAsync(Func<object?, Task> execute, Predicate<object?>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            // Blokujemy przycisk, jeśli komenda jest już w trakcie wykonywania (zapobiega double-click)
            return !isExecuting && (canExecute == null || canExecute(parameter));
        }

        public async void Execute(object? parameter)
        {
            isExecuting = true;
            // Odświeżamy stan CanExecute, aby przycisk się zablokował
            CommandManager.InvalidateRequerySuggested();

            try
            {
                await execute(parameter);
            }
            finally
            {
                isExecuting = false;
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}