using DiGi.UI.WPF.Interfaces;
using System.Windows;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for ProgressBarWindow.xaml
    /// </summary>
    public partial class ProgressBarWindow : Window, IWindow
    {
        public ProgressBarWindow()
        {
            InitializeComponent();
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
    }
}