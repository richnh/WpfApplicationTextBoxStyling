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

namespace WpfApplicationTextBoxStyling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_MouseEnter(object sender, MouseEventArgs e)
        {
            txtboxSelectedItem.Text = string.Format("{0}", listBox.Items.IndexOf(sender) );

            object oItem = listBox.Items.GetItemAt(listBox.Items.IndexOf(sender));

            ListViewItem lvItem = (ListViewItem)oItem;

            txtboxSelectedContent.Text = (string)lvItem.Content;
        }
    }
}
