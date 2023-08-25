namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Kết quả: {n}! = {giaiThua(n)}");
        }
        // tinh giai thua bang de quy
        static int giaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * giaiThua(n - 1);
        }
    }
}