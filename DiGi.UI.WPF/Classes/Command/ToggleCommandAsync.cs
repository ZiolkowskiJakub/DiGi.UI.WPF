using System.Windows.Input;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides an asynchronous implementation of the <see cref="ICommand"/> interface that prevents concurrent execution of the command logic.
    /// </summary>
    public class ToggleCommandAsync : ICommand
    {
        private readonly Func<object?, Task> execute;
        private readonly Predicate<object?>? canExecute;
        private bool isExecuting;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleCommandAsync"/> class.
        /// </summary>
        /// <param name="execute">The asynchronous delegate that defines the logic to be executed.</param>
        /// <param name="canExecute">An optional predicate that determines whether the command can be executed based on the provided parameter.</param>
        public ToggleCommandAsync(Func<object?, Task> execute, Predicate<object?>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Determines whether the command can be executed in its current state.
        /// </summary>
        /// <param name="parameter">The object to pass as a parameter to determine if the command can execute.</param>
        /// <returns>True if the command is not currently executing and the optional <c>canExecute</c> predicate returns true; otherwise, false.</returns>
        public bool CanExecute(object? parameter)
        {
            // Blokujemy przycisk, jeśli komenda jest już w trakcie wykonywania (zapobiega double-click)
            return !isExecuting && (canExecute == null || canExecute(parameter));
        }

        /// <summary>
        /// Executes the asynchronous logic associated with this command.
        /// </summary>
        /// <param name="parameter">The object to pass as a parameter to the execution logic.</param>
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

        /// <summary>
        /// Occurs when there is a change in the can-execute status of the command.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}