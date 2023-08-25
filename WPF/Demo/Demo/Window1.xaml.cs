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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnXemTT(object sender, RoutedEventArgs e)
        {
            string strMessage, strHoTen, strTitle;
            strHoTen = txtHoDem.Text + " " + txtTen.Text;
            if (radioNam.IsChecked == true)
            {
                strTitle = "Mr.";
            }
            else
            {
                strTitle = "Miss/Mrs.";
            }
            strMessage = "Xin chào:" + strTitle + " " + strHoTen;

            if (cboQueQuan.SelectedIndex >= 0)
            {
                strMessage += "\n Quê quán:" + cboQueQuan.Text;
            }
            MessageBox.Show(strMessage);
        }


    }
}
