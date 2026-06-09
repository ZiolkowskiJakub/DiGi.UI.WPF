using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    /// <summary>
    /// Provides functionality to debounce actions, ensuring that a specified action is executed only after a certain amount of time has passed since the last request.
    /// </summary>
    public sealed class Debouncer
    {
        private readonly DispatcherTimer dispatcherTimer;
        private Action? action;

        /// <summary>
        /// Initializes a new instance of the <see cref="Debouncer"/> class.
        /// </summary>
        /// <param name="delay">The interval in milliseconds to wait before executing the debounced action.</param>
        public Debouncer(int delay = 1000)
        {
            dispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(delay)
            };

            dispatcherTimer.Tick += OnTick;
        }

        /// <summary>
        /// Schedules the specified action for execution after the debounce interval has elapsed. 
        /// If this method is called again before the timer expires, the previous request is canceled and the timer resets.
        /// </summary>
        /// <param name="action">The action to be executed once the debounce period completes.</param>
        public void Run(Action action)
        {
            this.action = action;

            dispatcherTimer.Stop();   // reset timer on every call
            dispatcherTimer.Start();
        }

        private void OnTick(object? sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            action?.Invoke();
            action = null;
        }
    }
}