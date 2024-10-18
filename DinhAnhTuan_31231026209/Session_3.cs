using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhAnhTuan_31231026209
{
    internal class Session_3
    {
        public static void Main(string[] args)
        {
            //Ex_1();
            Ex_2(); 
            //Ex_3();
        }
        /// <summary>
        /// Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.
        /// </summary>
        public static void Ex_1()
        {
            Console.Write("Nhap nhiet do Celcius: ");
            double nhietdoC = double.Parse(Console.ReadLine());
            double nhietdoK = nhietdoC + 273;
            double nhietdoF = nhietdoC * 18 / 10 + 32;
            Console.WriteLine(@$"Nhiet do Kelvin tuong ung la: {nhietdoK} 
Nhiet do Fahrenheit tuong ung la: {nhietdoF}");
        }
        /// <summary>
        /// Create a program in C# for calculate the surface and volume of a sphere, given its radius.
        /// </summary>
        public static void Ex_2()
        {
            Console.Write("Nhap ban kinh cua hinh cau: ");
            double r = double.Parse(Console.ReadLine());
            double s = 4 * Math.Pow(r,2) * Math.PI;
            double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($@"Hinh cau duoc xac dinh co:
Dien tich be mat la {s}
The tich la {v}");
        }
        /// <summary>
        /// Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
        /// </summary>
        public static void Ex_3()
        {
            Console.Write("Nhap so thu nhat: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int so2 = int.Parse(Console.ReadLine());
            int tong = so1 + so2;
            int hieu = so1 - so2;
            int tich = so1 * so2;
            double thuong = so1 / so2;
            int phandu = so1 % so2;
            Console.WriteLine(@$"Tong cua hai so la {tong}
Hieu cua hai so la {hieu}
Tich cua hai so la {tich}
Thuong cua hai so la {thuong}
Thuong lay phan du cua hai so la {phandu}");
        }
    }
}
