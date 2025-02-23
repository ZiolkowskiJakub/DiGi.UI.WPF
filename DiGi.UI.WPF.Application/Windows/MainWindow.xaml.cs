using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Core;
using DiGi.UI.WPF.Core.Classes;
using DiGi.UI.WPF.Core.Windows;
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
            Query.ShowProgress((IDeterminateWorker determinateWorker) =>
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
                    determinateWorker.Report(i, i.ToString());
                    //((IndeterminateWindowWorker)sender).Report(i.ToString());
                }

                Dispatcher.Invoke(() =>
                {
                    Button_Start.IsEnabled = true;
                });
            }, this, "Calculating...");

            Query.ShowProgress((IIndeterminateWorker worker) =>
            {
                Dispatcher.Invoke(() =>
                {
                    Button_Start.IsEnabled = false;

                });

                //determinateWorker.Maximum = maximum;
                for (int i = 1; i <= maximum; i++)
                {
                    // Simulates work being done
                    Thread.Sleep(100);

                    // Reports progress
                    worker.Report(i.ToString());
                    //((IndeterminateWindowWorker)sender).Report(i.ToString());
                }

                Dispatcher.Invoke(() =>
                {
                    Button_Start.IsEnabled = true;
                });
            }, ProgressBarControl_Main, "Calculating...");


            //IndeterminateWindowWorker indeterminateProgressVisualWorker = new IndeterminateWindowWorker(this);
            //indeterminateProgressVisualWorker.DoWork += ProgressVisualWorker_DoWork;
            //indeterminateProgressVisualWorker.Run();


            //ProgressVisualWorker progressVisualWorker = new ProgressVisualWorker();
            //progressVisualWorker.Owner = this;
            //progressVisualWorker.DoWork += ProgressVisualWorker_DoWork;
            //progressVisualWorker.Maximum = maximum;
            //progressVisualWorker.Run();
        }

        private void Button_ShowWindow_Click(object sender, RoutedEventArgs e)
        {
            List<string> values = new List<string>()
            {
                "ONE TWO THREE",
                "TWO TWO ONE",
                "TWO TWO TWO"
            };

            bool? result;
            List<string>? selectedValues = null;

            //ListBoxWindow listBoxWindow = new ListBoxWindow();
            //listBoxWindow.ItemAdding += (sender, e) =>
            //{
            //    string? @string = e.Item as string;

            //    e.Name = @string;
            //};

            //listBoxWindow.SetItems(values);

            //result = listBoxWindow.ShowDialog();


            //if (result != null && result.Value)
            //{
            //    selectedValues = listBoxWindow.GetItems<string>(true);
            //    selectedValues = listBoxWindow.GetItems<string>(false);
            //}

            CheckBoxTreeViewWindow treeViewWindow = new CheckBoxTreeViewWindow("Test Window");
            treeViewWindow.ItemAdding += (sender, e) =>
            {
                string? @string = e.Item as string;

                e.Path = new ItemPath(@string?.Split(" "));
                e.Name = @string;
            };

            treeViewWindow.SetItems(values);

            result = treeViewWindow.ShowDialog();

            selectedValues = null;
            if (result != null && result.Value)
            {
                selectedValues = treeViewWindow.GetItems<string>(true);
            }
        }

        //private void ProgressVisualWorker_DoWork(object? sender, DoWorkEventArgs e)
        //{
        //    Dispatcher.Invoke(() =>
        //    {
        //        Button_Start.IsEnabled = false;

        //    });

        //    for (int i = 1; i <= maximum; i++)
        //    {
        //        // Simulates work being done
        //        Thread.Sleep(100);

        //        // Reports progress
        //        //((ProgressVisualWorker)sender).Report(i, i.ToString());
        //        ((IndeterminateWindowWorker)sender).Report(i.ToString());
        //    }

        //    Dispatcher.Invoke(() =>
        //    {
        //        Button_Start.IsEnabled = true;
        //    });
        //}
    }
}