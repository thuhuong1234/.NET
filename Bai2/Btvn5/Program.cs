namespace Btvn5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "matrix.txt"; // Đường dẫn đến file chứa ma trận

            try
            {
                int[,] matrix = ReadMatrixFromFile(filePath); // Đọc ma trận từ file
                int sum = CalculateMatrixSum(matrix); // Tính tổng các phần tử của ma trận
                AppendSumToFile(filePath, sum); // Ghi tổng tính được vào cuối file

                Console.WriteLine("Tính tổng và ghi thành công!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File không tồn tại.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng file không đúng.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            Console.ReadLine();
        }

        static int[,] ReadMatrixFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 3)
            {
                throw new FormatException("Định dạng file không đúng.");
            }

            int rows = int.Parse(lines[0]);
            int columns = int.Parse(lines[1]);

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i + 2].Split(' ');

                if (values.Length != columns)
                {
                    throw new FormatException("Định dạng file không đúng.");
                }

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        static int CalculateMatrixSum(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        static void AppendSumToFile(string filePath, int sum)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(sum);
            }
        }

    }
}