using System;
using System.Collections.Generic;

namespace NguyenThiThuHuong_435_proj62
//1
{
    interface IVehicle
    {
        void Input();
        void Output();

    }
    //2
    class Vehicle
    {
        public string id { get; set; }
        public string marker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string id)
        {
            this.id = id;
        }
        public Vehicle(string id, string marker, string model, int year, double price)
        {
            this.id = id;
            this.marker = marker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.Write("Id: ");
            id = Console.ReadLine();
            Console.Write("Marker: ");
            marker = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Marker: " + marker);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Price: " + price);

        }

        public override bool Equals(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return this.id.Equals(v.id);
        }

        public override string ToString()
        {
            return "Id: " + id + "Marker: " + marker + "Model: " + model + "Year: " + year + "Price: " + price;
        }

    }
    //3
    class Car : Vehicle
    {
        public string color { get; set; }
        public Car() : base()
        {

        }
        public Car(string id, string marker, string model, int year, double price, string color) : base(id, marker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Color:");
            color = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Color:" + color);
        }
    }

    //4
    class Truck : Vehicle
    {
        public int truckload { get; set; }

        public Truck() : base() { }

        public Truck(string id, string marker, string model, int year, double price, int truckload) : base(id, marker, model, year, price)
        {
            this.truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Truckload:");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Truckload:" + truckload);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Vehicle> li = new List<Vehicle>();
            
            while(true)
            {
                Console.WriteLine("1. Nhap du lieu");
                Console.WriteLine("2. Hien thi du lieu");
                Console.WriteLine("3. Tim kiem theo id");
                Console.WriteLine("4. Tim kiem theo marker");
                Console.WriteLine("5. Sap xep theo price");
                Console.WriteLine("6. Sap xep theo year");
                Console.WriteLine("7. Ket thuc");
                Console.WriteLine("Chon so tu (1-7):");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        li.Add(new Car("car01", "Mercedes", "BMW Seri 5", 2000, 1000, "black"));
                        li.Add(new Car("car02", "Mercedes", "BMW Seri 5", 2000, 1000, "black"));
                        li.Add(new Car("car02", "Mercedes", "BMW Seri 5", 3000, 1000, "black"));
                        li.Add(new Truck("car04", "Mercedes", "BMW Seri 5", 2000, 1000, 2000));
                        li.Add(new Truck("car05", "Mercedes", "BMW Seri 5", 2000, 1000, 1500));
                        li.Add(new Truck("car06", "Mercedes", "BMW Seri 5", 2000, 1000, 3000));
                        li.Add(new Truck("car07", "Mercedes", "BMW Seri 5", 2000, 1000, 3000));
                        li.Add(new Truck("car08", "Mercedes", "BMW Seri 5", 2000, 1000, 2000));
                        break;
                    case 2:
                        foreach(var item in li)
                        {
                            Console.WriteLine("==================");
                            item.Output();
                        }
                        break;
                    case 3:
                        string id2;
                        Console.WriteLine("Nhap id can tim: ");
                        id2 = Console.ReadLine();
                        int count = 0;
                        List<Vehicle> li1 = new List<Vehicle>();
                        foreach (var item in li)
                        {
                            if (id2 == item.id)
                            {
                                li1.Add(item);
                                count++;
                            }

                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Khong tim thay sap pham vua nhap");
                        }
                        else
                        {
                            foreach(var item in li1)
                            {
                                Console.WriteLine("==================");
                                item.Output();
                            }
                        }
                        break;
                    case 4:
                        string marker2;
                        Console.WriteLine("Nhap marker can tim: ");
                        marker2 = Console.ReadLine();
                        int count2 = 0;
                        List<Vehicle> li2 = new List<Vehicle>();
                        foreach (var item in li)
                        {
                            if (marker2 == item.marker)
                            {
                                li2.Add(item);
                                count2++;
                            }

                        }
                        if (count2 == 0)
                        {
                            Console.WriteLine("Khong tim thay sap pham vua nhap");
                        }
                        else
                        {
                            foreach(var item in li2)
                            {
                                Console.WriteLine("==================");
                                item.Output();
                            }
                        }
                        break;
                    case 5:
                        li.Sort();
                       
                        
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }
            };
        }
    }
}