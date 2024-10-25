using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DinhAnhTuan_31231026209
{
    internal class Session_4
    {
        public static void Main(string[] args)
        {
        Ex_1();
     //  Ex_2();
        }
        /// <summary>
        /// Write a C# Sharp program to display certain values of the function x = y^2+2y + 1 
        /// </summary>
        public static void Ex_1()
        {
            do
            {
                Console.Write("Nhap gia tri cua y [-5;5]: ");
                int y = int.Parse(Console.ReadLine());
                double x = Math.Pow(y, 2) + 2 * y + 1;

                if (y < -5 || y > 5)
                {
                    Console.WriteLine("Hay nhap gia tri hop le");
                    Console.WriteLine("");
                  
                }
                else
                {
                    Console.WriteLine($"Gia tri cua x khi y = {y} la: {x}");
                    break;
                }
            }while (true);
    }
        /// <summary>
        /// Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h)
        /// </summary>
        public static void Ex_2()
        {
            Console.WriteLine("Nhap thoi gian: ");
            Console.Write("gio: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("phut: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("giay: ");
            double giay = double.Parse(Console.ReadLine());
            Console.Write("Nhap khoang cach(km): ");
            double s = double.Parse(Console.ReadLine());
            double vkm = s / (h + m / 60 + giay / 3600);
            double vmi = vkm * 0.6213;
            Console.WriteLine($@"Van toc duoc tinh la {vkm}(km/h) hoac {vmi}(miles/h)");

        }/// <summary>
         /// Write a C# Sharp program that takes a character as input and checks if it
is a vowel, a digit, or any other symbol.
         /// </summary>
        public static void Ex_3()
        {

        }/// <summary>
         /// 
         /// </summary>
        public static void Ex_4()
        {

        }/// <summary>
         /// 
         /// </summary>
        public static void Ex_5()
        {

        }/// <summary>
         /// 
         /// </summary>
        public static void Ex_6()
        {

        }
    }
}
