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
        private readonly int maximum = 80;

        public MainWindow()
        {
            InitializeComponent();
        }

        private static void IndeterminateWindowWorkerTest()
        {
            //IndeterminateWindowWorker indeterminateProgressVisualWorker = new IndeterminateWindowWorker(this);
            //indeterminateProgressVisualWorker.DoWork += ProgressVisualWorker_DoWork;
            //indeterminateProgressVisualWorker.Run();
        }

        private static void ProgressVisualWorkerTest()
        {
            //ProgressVisualWorker progressVisualWorker = new ProgressVisualWorker();
            //progressVisualWorker.Owner = this;
            //progressVisualWorker.DoWork += ProgressVisualWorker_DoWork;
            //progressVisualWorker.Maximum = maximum;
            //progressVisualWorker.Run();
        }

        private void Button_ShowWindow_Click(object sender, RoutedEventArgs e)
        {
            List<string> values =
            [
                "ONE TWO THREE",
                "TWO TWO ONE",
                "TWO TWO TWO"
            ];

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

            CheckBoxTreeViewWindow treeViewWindow = new("Test Window");
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

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            CancellableIndeterminateWindowWorkerTest();
        }

        private void Button_TreeView_Click(object sender, RoutedEventArgs e)
        {
            List<string> strings =
            [
                "ONE TWO",
                "ONE TWO",
                "ONE TWO THREE THREE",
                "ONE TWO THREE THREE",
                "TWO TWO ONE TWO",
                "TWO TWO TWO",
                "TWO TWO ONE",
                "ONE THREE",
                "TWO TWO ONE FOUR"
            ];

            TreeViewControl_Main.ItemAdding += TreeViewControl_Main_ItemAdding;

            TreeViewControl_Main.SetItems(strings);

            TreeViewControl_Main.ItemAdding -= TreeViewControl_Main_ItemAdding;
        }

        private void CancellableIndeterminateWindowWorker_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Button_Start.IsEnabled = false;
            });

            CancellableIndeterminateWindowWorker? cancellableIndeterminateWindowWorker = sender as CancellableIndeterminateWindowWorker;

            //determinateWorker.Maximum = maximum;
            for (int i = 1; i <= maximum; i++)
            {
                // Simulates work being done
                Thread.Sleep(1000);

                if (cancellableIndeterminateWindowWorker is not null && cancellableIndeterminateWindowWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                // Reports progress
                cancellableIndeterminateWindowWorker?.Report(i.ToString());
            }

            Dispatcher.Invoke(() =>
            {
                Button_Start.IsEnabled = true;
            });
        }

        private void CancellableIndeterminateWindowWorkerTest()
        {
            CancellableIndeterminateWindowWorker cancellableIndeterminateWindowWorker = new();
            cancellableIndeterminateWindowWorker.DoWork += CancellableIndeterminateWindowWorker_DoWork;
            cancellableIndeterminateWindowWorker.Run();
        }

        private void DeterminateWorkerTest()
        {
            Query.ShowProgress(determinateWorker =>
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
            }, "Calculating...");
        }

        private void IndeterminateWorkerTest()
        {
            Query.ShowProgress(worker =>
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
        }

        private void TreeViewControl_Main_ItemAdding(object sender, TreeViewItemAddingEventArgs e)
        {
            if (e.Item is not string text)
            {
                return;
            }

            string[] values = text.Split(" ");

            e.Path = new ItemPath(values);
            e.Name = (string)e.Item;
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