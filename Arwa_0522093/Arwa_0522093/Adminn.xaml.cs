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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Arwa_0522093
{
    /// <summary>
    /// Interaction logic for Adminn.xaml
    /// </summary>
    public partial class Adminn : Page
    {
        public Adminn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();
            this.NavigationService.Navigate(delete);
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            search search = new search();
            this.NavigationService.Navigate(search);
        }
    }
}
