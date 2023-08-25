using ONTAP_TX2_1.Models;
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

namespace ONTAP_TX2_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            //truy vấn linQ 
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            // Hiển thị dữ liệu data grid
            data.ItemsSource = query.ToList();
        }
    }
}
