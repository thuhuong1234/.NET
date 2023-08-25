using System.Text;

namespace De003
{
    public class Program
    {
        static List <NhanVien> nhanViens = new List <NhanVien> ();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var p1 = new Program ();
            int choose;
           
                Console.WriteLine("-----------------Menu-------------------");
                Console.WriteLine($"1.Thêm ");
                Console.WriteLine($"2.Hiển thị danh sách");
                Console.WriteLine($"3.Sắp xếp");
            do
            {
                Console.WriteLine("Chọn :");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        p1.Add();
                        break;
                    case 2:
                        p1.Output();
                        break;
                    case 3:
                        p1.Sort();
                        break;
                    case 4:
                        Console.WriteLine("Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Không có sự lựa chọn nào");
                        break;

                }
            } while (choose != 4);  
           
        }
        public void Add()
        {
            NhanVien nv = new NhanVien();
            nv.Input();
            foreach(var item in nhanViens)
            {
                if(item.MaNV == nv.MaNV)
                {
                    Console.WriteLine($"Đã tồn tại MaNV");
                    return;
                }
            }
            nhanViens.Add(nv);
        }
        public void Output()
        {
            Title();
            Console.WriteLine("Danh sách nhân viên:");
            foreach(var item in nhanViens)
            {
                Console.WriteLine($"{item.Name,10}{item.Address,10}{item.MaNV,10}{item.ChucVu,10}{item.LuongCoBan,10}{item.tinhHeSo(),10}");
            }
            
        }
        public void Title()
        {
            Console.WriteLine($"{"Name",10}{"Address",10}{"MaNV",10}{"ChucVu",10}{"LuongCoBan",10}{"HeSo",10}");
        }
        public void Sort()
        {
            for(int i =0; i < nhanViens.Count - 1; i++)
            {
                for(int j =0;j< nhanViens.Count;j++)
                {
                    if (nhanViens[j].tinhHeSo() < nhanViens[i].tinhHeSo())
                    {
                        NhanVien tg = nhanViens[i];
                        nhanViens[i] = nhanViens[j];
                        nhanViens[j] = tg;
                    }
                }
            }
        }
    }
}