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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
            nf = new NetworkForm();
            af = new AgentForm();
            df = new DataForm();
            mf = new ModificationForm();
            nf.parself(this);
            af.parself(this);
            df.parself(this);
            mf.parself(this);
        }
        NetworkForm nf;
        AgentForm af;
        DataForm df;
        ModificationForm mf;
        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbUser.Text == "admin" && passwordBox.Password == "admin")
            {
                nf.Show();
                this.Hide();
            }

        }
        public void hideNet()
        {
            nf.Hide();
        }
        public void hideAgent()
        {
            af.Hide();
        }
        public void hideData()
        {
            df.Hide();
        }
        public void hideModification()
        {
            mf.Hide();
        }
        public void showNet()
        {
            nf.Show();
        }
        public void showAgent()
        {
            af.Show();
        }
        public void showData()
        {
            df.Show();
        }
        public void showModification()
        {
            mf.Show();
        }
    }
}
