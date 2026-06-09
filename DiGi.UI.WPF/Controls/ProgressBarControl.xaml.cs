using DiGi.UI.WPF.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for ProgressBarControl.xaml
    /// </summary>
    public partial class ProgressBarControl : UserControl, IControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarControl"/> class.
        /// </summary>
        public ProgressBarControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the progress bar with a specific value and optional descriptive text.
        /// </summary>
        /// <param name="value">The current progress value to be displayed.</param>
        /// <param name="text">Optional text to display as a label for the progress bar.</param>
        public void Update(double value, string? text = null)
        {
            ProgressBar_Main.Value = value;
            Label_Main.Content = text;
            SetVisibility();
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
        /// Gets or sets the current progress value.
        /// </summary>
        public double Value
        {
            get
            {
                return ProgressBar_Main.Value;
            }

            set
            {
                ProgressBar_Main.Value = value;
                SetVisibility();
            }
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
                SetVisibility();
            }
        }

        private void SetVisibility()
        {
            if (IsIndeterminate || Value == 0)
            {
                StackPanel_Main.Visibility = Visibility.Hidden;
                return;
            }

            StackPanel_Main.Visibility = Visibility.Visible;
        }
    }
}