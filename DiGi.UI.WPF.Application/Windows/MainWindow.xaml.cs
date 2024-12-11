using DiGi.UI.WPF.Core;
using DiGi.UI.WPF.Core.Classes;
using System.ComponentModel;
using System.Windows;

namespace DiGi.UI.WPF.Application.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int maximum = 80;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            Query.ShowProgress(() => 
            {
                Dispatcher.Invoke(() =>
                {
                    Button_Start.IsEnabled = false;

                });

                for (int i = 1; i <= maximum; i++)
                {
                    // Simulates work being done
                    Thread.Sleep(100);

                    // Reports progress
                    //((ProgressVisualWorker)sender).Report(i, i.ToString());
                    //((IndeterminateWindowWorker)sender).Report(i.ToString());
                }

                Dispatcher.Invoke(() =>
                {
                    Button_Start.IsEnabled = true;
                });
            });

            //IndeterminateWindowWorker indeterminateProgressVisualWorker = new IndeterminateWindowWorker(this);
            //indeterminateProgressVisualWorker.DoWork += ProgressVisualWorker_DoWork;
            //indeterminateProgressVisualWorker.Run();


            //ProgressVisualWorker progressVisualWorker = new ProgressVisualWorker();
            //progressVisualWorker.Owner = this;
            //progressVisualWorker.DoWork += ProgressVisualWorker_DoWork;
            //progressVisualWorker.Maximum = maximum;
            //progressVisualWorker.Run();
        }

        private void ProgressVisualWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Button_Start.IsEnabled = false;

            });

            for (int i = 1; i <= maximum; i++)
            {
                // Simulates work being done
                Thread.Sleep(100);

                // Reports progress
                //((ProgressVisualWorker)sender).Report(i, i.ToString());
                ((IndeterminateWindowWorker)sender).Report(i.ToString());
            }

            Dispatcher.Invoke(() =>
            {
                Button_Start.IsEnabled = true;
            });
        }
    }
}