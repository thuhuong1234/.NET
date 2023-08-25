namespace Btvn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so luong phan tu N = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Min = {arrayNumbers.Min()}");
            Console.WriteLine($"Max = {arrayNumbers.Max()}");
            Console.WriteLine($"Sum = {arrayNumbers.Sum()}");
        }
    }
}