namespace Bai7
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Nhập số lượng phần tử trong danh sách: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> danhSach = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                int phanTu = Convert.ToInt32(Console.ReadLine());
                danhSach.Add(phanTu);
            }

            List<int> soChan = LaySoChan(danhSach);
            List<int> soLe = LaySoLe(danhSach);
            List<int> soNguyenTo = LaySoNguyenTo(danhSach);

            Console.WriteLine("Các số chẵn trong danh sách:");
            HienThiDanhSach(soChan);

            Console.WriteLine("Các số lẻ trong danh sách:");
            HienThiDanhSach(soLe);

            Console.WriteLine("Các số nguyên tố trong danh sách:");
            HienThiDanhSach(soNguyenTo);
        }

        static List<int> LaySoChan(List<int> danhSach)
        {
            List<int> soChan = new List<int>();

            foreach (int phanTu in danhSach)
            {
                if (phanTu % 2 == 0)
                {
                    soChan.Add(phanTu);
                }
            }

            return soChan;
        }

        static List<int> LaySoLe(List<int> danhSach)
        {
            List<int> soLe = new List<int>();

            foreach (int phanTu in danhSach)
            {
                if (phanTu % 2 != 0)
                {
                    soLe.Add(phanTu);
                }
            }

            return soLe;
        }

        static List<int> LaySoNguyenTo(List<int> danhSach)
        {
            List<int> soNguyenTo = new List<int>();

            foreach (int phanTu in danhSach)
            {
                if (LaSoNguyenTo(phanTu))
                {
                    soNguyenTo.Add(phanTu);
                }
            }

            return soNguyenTo;
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void HienThiDanhSach(List<int> danhSach)
        {
            foreach (int phanTu in danhSach)
            {
                Console.Write($"{phanTu} ");
            }
            Console.WriteLine();
        }
    }
}