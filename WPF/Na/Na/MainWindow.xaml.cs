using Na.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Na
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
        //hiển thị 
        private void hienthi()
        {
            var temp = from sp in db.SanPhams
                       orderby sp.DonGia
                       select new
                       {
                           sp.MaSp,
                           sp.TenSp,
                           sp.MaLoai,
                           sp.DonGia,
                           sp.SoLuong,
                           ThanhTien = sp.SoLuong * sp.DonGia


                       };
            dgvSanPham.ItemsSource = temp.ToList();
        }
        //sử dụng combox hiển thị tên hàng từ bảng Loại sản phẩm
        private void hienthicb()
        {
            var temp = from lsp in db.LoaiSanPhams
                       select lsp;
            combLoaisp.ItemsSource = temp.ToList();
            combLoaisp.DisplayMemberPath = "TenLoai";
            combLoaisp.SelectedValuePath = "MaLoai";
            combLoaisp.SelectedIndex = 0;

        }
              
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            hienthi();
            hienthicb();
        }
        //thêm
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
            if (query == null)
            {
                SanPham newSP = new SanPham();
                newSP.MaSp = txtMaSP.Text;
                newSP.TenSp = txtTenSP.Text;
                newSP.DonGia = double.Parse(txtDG.Text);
                newSP.SoLuong = int.Parse(txtSL.Text);

                LoaiSanPham itemSelected = (LoaiSanPham)combLoaisp.SelectedItem;
                newSP.MaLoai = itemSelected.MaLoai;
                db.SanPhams.Add(newSP);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                hienthi();
                
            }
            else
            {
                MessageBox.Show("Mã SP đã tồn tại ", "Thông báo");
                hienthi();
                
            }
        }

        //sửa
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //xác định sản phẩm cần sửa
            var spSua = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
            if (spSua != null)
            {
               
                spSua.TenSp = txtTenSP.Text;
                spSua.DonGia = double.Parse(txtDG.Text);
                spSua.SoLuong = int.Parse(txtSL.Text);

                LoaiSanPham itemSelected = (LoaiSanPham)combLoaisp.SelectedItem;
                spSua.MaLoai = itemSelected.MaLoai;
                
                db.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                hienthi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần sửa");
                hienthi();  
            }
        }
        //xóa
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var spXoa = db.SanPhams.SingleOrDefault(t=>t.MaSp.Equals(txtMaSP.Text));
            
            if(spXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông báo ",MessageBoxButton.YesNo);
                if(rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);
                    db.SaveChanges();
                    hienthi();
                }
               

            }
            else
            {
                MessageBox.Show("Không có sản phẩm cần xóa ", "Thông báo");
                hienthi();
            }

        }

        //tìm từ combox
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            /**
             * if (dgvSanPham.SelectedItem != null)
            {
                try
                {
                    Type t = dgvSanPham.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMaSP.Text = p[0].GetValue(dgvSanPham.SelectedValue).ToString();
                    txtTenSP.Text = p[1].GetValue(dgvSanPham.SelectedValue).ToString();
                    combLoaisp.SelectedValue = p[2].GetValue(dgvSanPham.SelectedValue);
                    txtDG.Text = p[3].GetValue(dgvSanPham.SelectedValue).ToString();
                    txtSL.Text = p[4].GetValue(dgvSanPham.SelectedValue).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn hàng " + ex.Message, "Thông báo");
                }

            }
             */
            

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var spThongKe = db.SanPhams.SingleOrDefault(p => p.MaSp.Equals(txtMaSP.Text));
            if(spThongKe != null)
            {
                MessageBox.Show("Sản phẩm vừa nhập:", "Thông báo");
                var temp = from sp in db.SanPhams
                           where(sp.MaSp.Equals(txtMaSP.Text))
                           select new
                           {
                               sp.MaSp,
                               sp.TenSp,
                               sp.MaLoai,
                               sp.DonGia,
                               sp.SoLuong,
                               ThanhTien = sp.SoLuong * sp.DonGia


                           };
                dgvSanPham.ItemsSource = temp.ToList();

            }
            else
            {
                MessageBox.Show("Sản phẩm vừa nhập không có trong bảng");
            }
        }

        
    }
}
