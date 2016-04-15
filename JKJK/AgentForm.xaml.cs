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
    /// Interaction logic for AgentForm.xaml
    /// </summary>
    public partial class AgentForm : Window
    {
        public AgentForm()
        {
            InitializeComponent();
        }
        LoginForm lf;
        public void parself(LoginForm lf)
        {
            this.lf = lf;
        }

        private void btData_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showData();
        }

        private void btModify_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showModification();
        }

        private void btNetwork_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.showNet();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            lf.Show();
        }
        DateTime dt = DateTime.Now;
        
        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            String[] faceset = { "上", "下", "左", "右" };
            TimeSpan ts = DateTime.Now - dt;
            tbcNumber.Text = tbIndex.Text;
            double x = rd.NextDouble() * 10 + ts.TotalMilliseconds / 100.0;
            if(x>120)
            {
                x = (int)x % 120+rd.NextDouble();
            }
            tbTime.Text = Math.Round(x, 2).ToString();
            tbDes.Text = rd.Next(25).ToString();
            tbCoorx.Text = (Math.Round(rd.NextDouble() * 500)).ToString();
            tbCoorY.Text=( Math.Round(rd.NextDouble() * 500)).ToString();
            tbFace.Text = faceset[rd.Next(3)];
        }
    }
}
