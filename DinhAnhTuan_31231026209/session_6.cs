using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DinhAnhTuan_31231026209
{
    internal class session_6
    {
        public static void Main(string[] args)
        {
            //Ex1();
            Ex2();
        }
        /// <summary>
        /// declare an array N items. With N is enter from users.
        /// 1. Enter items values for this array
        /// 2. Print the array to the screen
        /// 3. Write funtion that increase each item of the array by adding it with 2
        /// 4. print the array to the screen
        /// 5. Write a function to calculate the sum of all items of the array.
        /// 6 (optional). avg, min, max,....
        /// </summary>
        public static void taomang(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i ++)
            {
                a[i] = random.Next(100);
            }
           
        }
        public static void inmang(int[] a)
        { 
            foreach (int i in a)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        public static void tanggiatri(int[] a, int b)
        {
            for (int i = 0;i < a.Length;i ++)
            {
                a[i] += b;
            }    
        }
        public static double tinhtong(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static double trungbinh(int[] a)
        {
            double avg = tinhtong(a) / a.Length;
            Console.WriteLine($"Gia tri trung binh cua mang la: {avg}");
            return avg;
        }
        public static int min(int[] a)
        {
            int min = a[1];
            foreach (int i in a)
                if (i < min)
                    min = a[i];
            return min;
        }
        public static void Ex1()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            taomang(a);
            inmang(a);
            tanggiatri(a, 2);
            inmang(a);
            double x=tinhtong(a);
            Console.WriteLine($"tong cua mang la: {x}");
            trungbinh(a);
            int y = min(a);
            Console.WriteLine($"gia tri nho nhat cua mang la: {y}");
        }
        /// <summary>
        /// Create a random integer values array, then create functions that:
        /// 1. to calculate the average value of array elements.
        /// 2. to test if an array contains a specific value.
        /// 3. to find the index of an array element.
        /// 4. to remove a specific element from an array.
        /// 5. to find the maximum and minimum value of an array.
        /// 6. to reverse an array of integer values.
        /// 7. to find duplicate values in an array of values.
        /// 8. to remove duplicate elements from an array.
        /// </summary>
        public static bool cogiatrikhong(int[] a, int giatri)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == giatri)
                {
                    Console.WriteLine("Co gia tri nay trong mang");
                    return true;
                }
            }
            Console.WriteLine("Khong co giá tri nay trong mang");
            return false;
        }
        public static int vitrigiatri(int[] a, int giatri)
        {
            int vitri;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == giatri)
                {
                    vitri = i;
                    return vitri;
                }
            }
            vitri = -1;
            return vitri;
        }
        public static void Ex2()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            taomang(a);
            trungbinh(a); //1.
            inmang(a);
            Console.Write("Nhap gia tri muon kiem tra: "); //2.
            int gt= int.Parse(Console.ReadLine());
            cogiatrikhong(a, gt);
            int vitri = vitrigiatri(a, gt); //3.
            if (vitri == -1)
                Console.WriteLine("Khong co gai tri nay trong mang");
            else { Console.WriteLine($"Gia tri nay o vi tri {vitri} cua mang"); }

        }
    }
}
