using System.Windows;

namespace DiGi.UI.WPF.Core.Windows
{
    /// <summary>
    /// Interaction logic for ProgressBarWindow.xaml
    /// </summary>
    public partial class ProgressBarWindow : Window
    {
        public ProgressBarWindow()
        {
            InitializeComponent();
        }

        public void Update(double value, string text = null)
        {
            // When progress is reported, update the progress bar control.
            ProgressBar_Main.Value = value;
            Label_Main.Content = text;

            // When progress reaches 100%, close the progress bar window.
            //if (value == Maximum)
            //{
            //    Close();
            //}
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
    }
}
