﻿using System;
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
    /// Interaction logic for DataForm.xaml
    /// </summary>
    public partial class DataForm : Window
    {
        LoginForm lf;
        public DataForm()
        {
            InitializeComponent();
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
    }
}
