using DiGi.UI.WPF.Core.Interfaces;
using System.Windows;
using System.Windows.Controls;


namespace DiGi.UI.WPF.Core.Controls
{
    /// <summary>
    /// Interaction logic for ProgressBarControl.xaml
    /// </summary>
    public partial class ProgressBarControl : UserControl, IControl
    {
        public ProgressBarControl()
        {
            InitializeComponent();
        }

        public void Update(double value, string text = null)
        {
            ProgressBar_Main.Value = value;
            Label_Main.Content = text;
            SetVisibility();
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
            if(IsIndeterminate || Value == 0)
            {
                StackPanel_Main.Visibility = Visibility.Hidden;
                return;
            }

            StackPanel_Main.Visibility = Visibility.Visible;
        }
    }
}
