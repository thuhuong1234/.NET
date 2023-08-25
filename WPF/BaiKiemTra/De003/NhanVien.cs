using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De003
{
    public class NhanVien:Person
    {
        public string MaNV { get; set; }    
        public long LuongCoBan { get; set; }
        public string ChucVu { get; set; }
        public override void Input()
        {
            base.Input();
            Console.Write($"Nhap ma nv: ");
            MaNV = Console.ReadLine();
            Console.Write($"Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write($"Nhap luong co ban: ");
            LuongCoBan = long.Parse(Console.ReadLine());
        }

        public int tinhHeSo()
        {
            if (ChucVu == "Giám đốc")
                return 10;
            else if (ChucVu == "Trưởng phòng" || ChucVu == "Phó giám đốc")
                return 6;
            else if (ChucVu == "Phó phòng")
                return 4;
            else
                return 2;
        }
    }
}
