namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khoi tao bien
            int chieuDai, chieuRong;
            // nhap du lieu
            Console.Write("Nhap vao chieu dai = ");
            chieuDai = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap vao chieu rong = ");
            chieuRong = Convert.ToInt32(Console.ReadLine());
            // hien thi chu vi va dien tich
            Console.WriteLine($"\nChu vi hinh chu nhat = {(chieuDai + chieuRong) * 2}");
            Console.WriteLine($"\nDien tich hinh chu nhat = {chieuDai * chieuRong}");
        }
    }
}