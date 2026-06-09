using System.Windows.Input;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Implements the <see cref="ICommand"/> interface to provide a command that executes a specified action.
    /// </summary>
    public class ToggleCommand : ICommand
    {
        private readonly Action<object?> execute;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleCommand"/> class.
        /// </summary>
        /// <param name="execute">The action to perform when the command is executed.</param>
        public ToggleCommand(Action<object?> execute)
        {
            this.execute = execute;
        }

        /// <summary>
        /// Occurs when conditions change that affect whether the command can be executed.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">The parameter to check for execution capability.</param>
        /// <returns>Always returns <c>true</c>, indicating that the command is always available for execution.</returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the command logic.
        /// </summary>
        /// <param name="parameter">The parameter to pass to the execute action.</param>
        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}