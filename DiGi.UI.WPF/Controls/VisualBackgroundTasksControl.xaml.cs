using DiGi.UI.WPF.Interfaces;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace DiGi.UI.WPF.Controls
{
    public partial class VisualBackgroundTasksControl : UserControl
    {
        /// <summary>
        /// Identifies the <see cref="VisualBackgroundTasks"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty VisualBackgroundTasksProperty = DependencyProperty.Register(nameof(VisualBackgroundTasks), typeof(ObservableCollection<IVisualBackgroundTask>), typeof(VisualBackgroundTasksControl), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the collection of visual background tasks to be displayed and managed by the control.
        /// </summary>
        public ObservableCollection<IVisualBackgroundTask>? VisualBackgroundTasks
        {
            get => (ObservableCollection<IVisualBackgroundTask>?)GetValue(VisualBackgroundTasksProperty);
            set => SetValue(VisualBackgroundTasksProperty, value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualBackgroundTasksControl"/> class.
        /// </summary>
        public VisualBackgroundTasksControl()
        {
            InitializeComponent();

            //DataContext = this;
        }
    }
}