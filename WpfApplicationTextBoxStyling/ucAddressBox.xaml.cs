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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplicationTextBoxStyling
{
    /// <summary>
    /// Interaction logic for ucAddressBox.xaml
    /// </summary>
    public partial class ucAddressBox : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public ucAddressBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtAddress.IsReadOnly       = !txtAddress.IsReadOnly;
            txtAddressLine2.IsReadOnly  = !txtAddressLine2.IsReadOnly;
        }
    }
}
