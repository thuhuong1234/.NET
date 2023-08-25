namespace Bai5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Chọn tác vụ:");
            Console.WriteLine("1. Chuyển đổi số nguyên từ hệ cơ số 10 sang hệ cơ số B bất kỳ.");
            Console.WriteLine("2. Chuyển đổi một số từ hệ cơ số B bất kỳ sang hệ cơ số 10.");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ConvertFromDecimal();
                    break;
                case 2:
                    ConvertToDecimal();
                    break;
                default:
                    Console.WriteLine("Tác vụ không hợp lệ.");
                    break;
            }
        }

        static void ConvertFromDecimal()
        {
            Console.Write("Nhập số nguyên N (hệ cơ số 10): ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập hệ cơ số B: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            string result = ConvertFromDecimalToBase(number, baseNumber);
            Console.WriteLine($"Kết quả: {result} (hệ cơ số {baseNumber})");
        }

        static void ConvertToDecimal()
        {
            Console.Write("Nhập số N (hệ cơ số B): ");
            string number = Console.ReadLine();

            Console.Write("Nhập hệ cơ số B: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            int result = ConvertToDecimalFromBase(number, baseNumber);
            Console.WriteLine($"Kết quả: {result} (hệ cơ số 10)");
        }

        static string ConvertFromDecimalToBase(int number, int baseNumber)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int remainder = number % baseNumber;
                char digit = GetDigit(remainder);
                result = digit + result;
                number /= baseNumber;
            }

            return result;
        }

        static int ConvertToDecimalFromBase(string number, int baseNumber)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digitValue = GetDigitValue(number[i]);
                result = result * baseNumber + digitValue;
            }

            return result;
        }

        static char GetDigit(int value)
        {
            if (value >= 0 && value <= 9)
            {
                return (char)(value + '0');
            }
            else
            {
                return (char)(value - 10 + 'A');
            }
        }

        static int GetDigitValue(char digit)
        {
            if (char.IsDigit(digit))
            {
                return digit - '0';
            }
            else
            {
                return char.ToUpper(digit) - 'A' + 10;
            }
        }
    }
}