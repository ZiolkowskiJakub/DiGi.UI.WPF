using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public sealed class Debouncer
    {
        private readonly DispatcherTimer dispatcherTimer;
        private Action? action;

        public Debouncer(int delay = 1000)
        {
            dispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(delay)
            };

            dispatcherTimer.Tick += OnTick;
        }

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