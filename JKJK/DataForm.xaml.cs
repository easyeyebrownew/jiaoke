using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.ViewportRestrictions;

namespace JKJK
{
    /// <summary>
    /// Interaction logic for DataForm.xaml
    /// </summary>
    public partial class DataForm : Window
    {
        LoginForm lf;
        public DataForm()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }
        ObservableDataSource<Point> source1 = null;

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            source1 = new ObservableDataSource<Point>();
            // Set identity mapping of point in collection to point on plot
            source1.SetXYMapping(p => p);
            plotter.AddLineGraph(source1, 2, "Data row 1");
            Thread simThread = new Thread(new ThreadStart(Simulation));
            simThread.IsBackground = true;
            simThread.Start();
        }


        private void Simulation()
        {
            

                       

                        Point p1 = new Point(3,4);
                        Point p2 = new Point(3, 5);
                        Point p3 = new Point(4, 8);

                        source1.AppendAsync(Dispatcher, p1);
                        source1.AppendAsync(Dispatcher, p2);
                        source1.AppendAsync(Dispatcher, p3);

                    
                    
                
            
        }

        private void btNetwork_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showAgent();
        }
        public void parself(LoginForm lf)
        {
            this.lf = lf;
        }
        private void btModify_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showModification();
        }

        private void btNetwork_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showNet();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Point p3 = new Point(5, 10);
            Point p4 = new Point(6, 20);
            source1.AppendAsync(Dispatcher, p3);
            source1.AppendAsync(Dispatcher, p4);
        }
    }

    
}
