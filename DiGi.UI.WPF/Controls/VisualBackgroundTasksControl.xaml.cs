using DiGi.UI.WPF.Interfaces;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for VisualBackgroundTasksControl.xaml
    /// </summary>
    public partial class VisualBackgroundTasksControl : UserControl
    {
        // 1. Register the DependencyProperty
        public static readonly DependencyProperty VisualBackgroundTasksProperty = DependencyProperty.Register(nameof(VisualBackgroundTasks), typeof(ObservableCollection<IVisualBackgroundTask>), typeof(VisualBackgroundTasksControl), new PropertyMetadata(null));

        // 2. CLR Wrapper for the DependencyProperty
        public ObservableCollection<IVisualBackgroundTask>? VisualBackgroundTasks
        {
            get => (ObservableCollection<IVisualBackgroundTask>?)GetValue(VisualBackgroundTasksProperty);
            set => SetValue(VisualBackgroundTasksProperty, value);
        }

        public VisualBackgroundTasksControl()
        {
            InitializeComponent();

            //DataContext = this;
        }
    }
}
