using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De003
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual void Input()
        {
            Console.WriteLine("Nhập tên:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ:");
            Address = Console.ReadLine();
        }
    }
}
