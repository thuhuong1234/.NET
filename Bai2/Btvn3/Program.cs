namespace Btvn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ThanhPho = new List<string>();

            // Thêm 5 thành phố trực thuộc trung ương của Việt Nam
            ThanhPho.Add("Hà Nội");
            ThanhPho.Add("Hồ Chí Minh");
            ThanhPho.Add("Đà Nẵng");
            ThanhPho.Add("Hải Phòng");
            ThanhPho.Add("Cần Thơ");

            // Sắp xếp danh sách theo thứ tự tăng dần
            ThanhPho.Sort();

            // In danh sách đã sắp xếp
            Console.WriteLine("Danh sách thành phố đã sắp xếp theo thứ tự tăng dần:");
            foreach (string thanhPho in ThanhPho)
            {
                Console.WriteLine(thanhPho);
            }

            // Xóa thành phố "Hà Nội" và thêm vào 5 thành phố lớn khác
            ThanhPho.Remove("Hà Nội");
            ThanhPho.Add("Đà Lạt");
            ThanhPho.Add("Nha Trang");
            ThanhPho.Add("Huế");
            ThanhPho.Add("Phú Quốc");
            ThanhPho.Add("Vũng Tàu");

            // In toàn bộ danh sách
            Console.WriteLine("Danh sách thành phố sau khi xóa 'Hà Nội' và thêm 5 thành phố khác:");
            foreach (string thanhPho in ThanhPho)
            {
                Console.WriteLine(thanhPho);
            }
        }
    }
}