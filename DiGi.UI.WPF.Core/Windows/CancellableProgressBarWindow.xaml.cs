using DiGi.UI.WPF.Core.Delegates;
using DiGi.UI.WPF.Core.Interfaces;
using System.Windows;


namespace DiGi.UI.WPF.Core.Windows
{
    /// <summary>
    /// Interaction logic for CancellableProgressBarWindow.xaml
    /// </summary>
    public partial class CancellableProgressBarWindow : Window, IWindow
    {
        private bool cancellationPending = false;

        public CancellableProgressBarWindow()
        {
            InitializeComponent();
        }

        public event CancellingEventHandler? Cancelling;
        
        public bool CancellationPending
        {
            get
            {
                return cancellationPending;
            }
        }

        public bool IsIndeterminate
        {
            get
            {
                return ProgressBar_Main.IsIndeterminate;
            }

            set
            {
                ProgressBar_Main.IsIndeterminate = value;
                StackPanel_Main.Visibility = value ? Visibility.Hidden : Visibility.Visible;
            }
        }

        public double Maximum
        {
            get
            {
                return ProgressBar_Main.Maximum;
            }

            set
            {
                ProgressBar_Main.Maximum = value;
            }
        }

        public void Update(double value, string? text = null)
        {
            ProgressBar_Main.Value = value;
            Label_Main.Content = text;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            cancellationPending = true;

            Cancelling?.Invoke(sender, new Classes.CancellingEventArgs());
        }
    }
}
