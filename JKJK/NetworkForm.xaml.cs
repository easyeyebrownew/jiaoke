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

namespace JKJK
{
    /// <summary>
    /// Interaction logic for NetworkForm.xaml
    /// </summary>
    public partial class NetworkForm : Window
    {
        public NetworkForm()
        {
            InitializeComponent();
        }
        LoginForm lf;
        private void btData_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showData();
        }
        public void parself(LoginForm lf)
        {
            this.lf = lf;
        }
        private void btAgent_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showAgent();
        }

        private void btModify_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showModification();
        }
    }
}
