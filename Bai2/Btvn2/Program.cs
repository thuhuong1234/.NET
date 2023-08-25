namespace Btvn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string inputString = Console.ReadLine();

            // a. Hien thi moi ky tu tren 1 dong
            Console.WriteLine("Ket qua (moi ky tu tren 1 dong): ");
            foreach (char c in inputString)
            {
                Console.WriteLine(c);
            }

            // b. Hien thi moi tu tren 1 dong (bo qua khoang trang thua)
            Console.WriteLine("Ket qua (moi tu tren 1 dong): ");
            string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // c. Dem so lan xuat hien cua moi ky tu trong chuoi
            Console.WriteLine("Ket qua (so lan xuat hien cua moi ky tu): ");
            int[] charCount = new int[256]; // Su dung mang int co do dai 256 de dem so lan xuat hien cua moi ky tu (ASCII)
            foreach (char c in inputString)
            {
                charCount[(int)c]++;
            }

            for (int i = 0; i < 256; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine($"Ky tu '{(char)i}' xuat hien {charCount[i]} lan");
                }
            }
        }
    }
}