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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ONTAP_TX2_1
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

        QLBanHangContext db = new QLBanHangContext();
        private void HienThiDuLieu()
        {
            var sp = db.SanPhams.OrderBy(p => p.DonGia).Select(p => new { p.MaSp, p.TenSp, p.MaLoai, p.DonGia, p.SoLuong, ThanhTien = p.DonGia * p.SoLuong });
            data.ItemsSource = sp.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
