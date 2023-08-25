namespace Btvn4
{
    struct HocSinh
    {
        public string HoTen;
        public int Tuoi;
        public bool GioiTinh;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HocSinh[] danhSachHocSinh = new HocSinh[5];

            // Nhập dữ liệu cho mảng học sinh
            for (int i = 0; i < danhSachHocSinh.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin học sinh {i + 1}:");
                Console.Write("Họ tên: ");
                danhSachHocSinh[i].HoTen = Console.ReadLine();
                Console.Write("Tuổi: ");
                danhSachHocSinh[i].Tuoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Giới tính (Nam: true, Nữ: false): ");
                danhSachHocSinh[i].GioiTinh = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine();
            }

            // Tính tổng số tuổi của 5 học sinh
            int tongTuoi = 0;
            foreach (HocSinh hocSinh in danhSachHocSinh)
            {
                tongTuoi += hocSinh.Tuoi;
            }

            // In ra tổng số tuổi
            Console.WriteLine("Tổng số tuổi của 5 học sinh: " + tongTuoi);
        }
    }
}