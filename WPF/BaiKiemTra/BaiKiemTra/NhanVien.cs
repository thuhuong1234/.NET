using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class NhanVien:TinhLuong
    {
        public string MaNV { get; set; }    
        public string ChucVu { get; set; }
        public override double Luong()
        {
            double pc = 0f;
            if (ChucVu == "Giam doc")
            {
                pc = 0.5f;
            }else if (ChucVu =="Truong phong")
            {
                pc = 0.4f;
            }else if(ChucVu =="Pho phong")
            {
                pc = 0.3f;
            }

            return (HeSo + pc) * LuongCoBan;
        }
           
   }
    
}
