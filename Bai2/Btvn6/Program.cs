namespace Btvn6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadArrayFromConsole(); // Tạo và nhập vào một mảng các số nguyên

            Console.WriteLine("Các số nguyên tố trong mảng:");
            PrintPrimeNumbers(numbers); // Kiểm tra và in ra các số nguyên tố trong mảng

            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int[] ReadArrayFromConsole()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static void PrintPrimeNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}