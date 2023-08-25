using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class Program
    {
        static List<NhanVien> nhanViens = new List<NhanVien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var p1 = new Program();

            int choose;
            Console.WriteLine($"1. Thêm");
            Console.WriteLine($"2. Hiển thị danh sách");
            Console.WriteLine($"3. Sắp xếp");
            Console.WriteLine($"4. Thoát");
            do
            {
                Console.WriteLine("Chon phim tu 1-4:");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        p1.AddNhanVien();
                        break;
                    case 2:
                        p1.HienThiDS();
                        break;
                    case 3:
                        p1.SapXep();
                        break;
                    case 4:
                        Console.WriteLine("Ket thuc");
                        break;
                    case 5:                      
                        p1.Xoa();
                        break;
                    case 6:
                        p1.Sua();
                        break;
                    default: Console.WriteLine("Khong co su lua chon nao");
                        break;
                }
            } while (choose != 4);
        }
        public void AddNhanVien()
        {
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhập tên:");
            nv.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ:");
            nv.DiaChi = Console.ReadLine();
            Console.WriteLine("Nhập hệ số lương:");
            nv.HeSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Lương cơ bản:");
            nv.LuongCoBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mã nhân viên:");
            nv.MaNV = Console.ReadLine();
            Console.WriteLine("Nhập chức vụ:");
            nv.ChucVu = Console.ReadLine();

            nhanViens.Add(nv);
        }

        public void HienThiDS()
        {
            Console.WriteLine("Danh sach nhan vien:");
            Title();
            foreach (var item in nhanViens)
            {
                Console.WriteLine($"{item.HoTen,10}{item.DiaChi,10}{item.HeSo,10}{item.LuongCoBan,10}{item.MaNV,10}{item.ChucVu,10}{item.Luong(),10}");
            }
        }
        public void Title() {
            Console.WriteLine($"{"Họ tên",10}{"Địa chỉ",10}{"Hệ số",10}{"LươngCB",10}{"MaNV",10}{"Chức vụ",10}{"Lương",10}");
        }
        public void SapXep()
        {
            for (int i = 0; i < nhanViens.Count - 1; i++)
            {
                for (int j = i + 1; j < nhanViens.Count; j++)
                {
                    if (nhanViens[j].Luong() < nhanViens[i].Luong())
                    {
                        NhanVien tg = nhanViens[j];
                        nhanViens[j] = nhanViens[i];
                        nhanViens[i] = tg;

                    }
                }
            }
        }

        public void Xoa()
        {
            for (int i = nhanViens.Count - 1; i >= 0; i--)
            {
                if (nhanViens[i].HoTen == "Hường")
                {
                    nhanViens.RemoveAt(i);
                }
            }
        }

        public void Sua()
        {
            foreach (var item in nhanViens)
            {
                if (item.ChucVu == "Giam doc")
                {
                    item.HeSo = 4;
                }
            }
        }
    }

    
}
