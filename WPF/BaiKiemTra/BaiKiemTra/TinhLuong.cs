namespace BaiKiemTra
{
    public class TinhLuong
    {
        public  string HoTen { get; set; }
        public  string DiaChi { get; set; }  
        public int HeSo { get; set; }
        public double LuongCoBan { get; set; }
        public virtual double Luong()
        {
            return HeSo * LuongCoBan;
        }
         public TinhLuong() 
        { 
            HoTen = string.Empty;
            DiaChi = string.Empty;  
            HeSo = 0;
            LuongCoBan = 0;
        }
        public TinhLuong(string HoTen, string DiaChi, int HeSo, double LuongCoBan)
        {
            this.HoTen = HoTen; 
            this.DiaChi = DiaChi;   
            this.HeSo = HeSo;   
            this.LuongCoBan = LuongCoBan;
        }
        
    }
}