namespace Bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khoi tao bien
            int n;
            // nhap du lieu
            Console.Write("Nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] fiboArrays = new int[n];
            fiboArrays[0] = 0;
            fiboArrays[1] = 1;

            for (int i = 2; i < n; i++)
                fiboArrays[i] = fiboArrays[i - 1] + fiboArrays[i - 2];

            // hien thi day fibo
            foreach (int item in fiboArrays)
                Console.Write($"{item}, ");
        }
    }
}