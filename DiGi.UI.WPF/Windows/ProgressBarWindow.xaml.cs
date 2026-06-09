using DiGi.UI.WPF.Interfaces;
using System.Windows;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for ProgressBarWindow.xaml
    /// </summary>
    public partial class ProgressBarWindow : Window, IWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarWindow"/> class.
        /// </summary>
        public ProgressBarWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the progress bar is in an indeterminate state.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the maximum value for progress reporting.
        /// </summary>
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

        /// <summary>
        /// Updates the progress bar's current value and optionally updates the status text.
        /// </summary>
        /// <param name="value">The current progress value to be displayed.</param>
        /// <param name="text">The optional text to display as a status message.</param>
        public void Update(double value, string? text = null)
        {
            ProgressBar_Main.Value = value;
            Label_Main.Content = text;
        }
    }
}