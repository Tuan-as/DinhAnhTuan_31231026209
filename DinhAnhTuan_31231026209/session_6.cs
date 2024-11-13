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
using System.Runtime;
using System.Reflection.Metadata.Ecma335;

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
            for (int i = 0; i < a.Length; i++)
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
            for (int i = 0; i < a.Length; i++)
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
            int min = a[0];
            for (int i = 0;i < a.Length;i++)
                if (a[i] < min)
                {
                    min = a[i];
                }
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
            double x = tinhtong(a);
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
                    
                    return true;
                }
            }
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
        public static int[] delai1gttrunglap(int[] a, int b)
        {
            int count = 0, j = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b)
                {
                    count++;
                }
            int[] x = new int[a.Length - count+1];
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] == b) && (dem ==0))
                {
                    dem++;
                    x[i - j] = a[i];
                    continue;
                }
                else if (a[i]==b)
                {
                    j++;
                }
                else x[i - j] = a[i];
            }
            return x;
        }
        public static int[] loaibophantu(int[] a, int b)
        {
            int count=0 ,j = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b)
                {
                    count++;
                }
            int[] x = new int[a.Length -count];
            for (int i = 0;i < a.Length;i++)
            {
                if (a[i] == b)
                {
                    j++;
                }    
                else x[i-j] = a[i];
            }
            return x;
        }
        public static int max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (a[i] > max)
                { 
                    max = a[i];
                }
            return max;
        }
        public static void swap( ref int a, ref int b)
        {
            int c = a; a = b; b = c;
        }
        public static void daonguocmang(int[] a)
        {
            
            for (int i = 0; i <= (a.Length / 2 - 1); i++)
            {
                swap(ref a[i], ref a[a.Length - 1 - i]);
            }    
        }
        public static bool cotrunglapkhong(int[] a, int b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (b == a[i])
                    count++;
                if (count >= 2)
                    return true;
            }
            return false;
        }
        public static int sogiatritrunglap(int[] a)
        {
            int count = 0;
            int[] x = a;
            int i = 0;
            do
            {
                i = 0;
                if (x.Length == 0)
                    break;
                if (cotrunglapkhong(x, x[i]) == true)
                {
                    count++;
                    x = loaibophantu(x, x[i]);
                }
                else
                {
                    x = loaibophantu(x, x[i]);
                }

            }
            while (true);
            return count;
        }
        public static int[] giatritrunglap(int[] a)
        {
            if (sogiatritrunglap(a) == 0)
            {
                Console.WriteLine("Mang khong co gia tri trung lap!");
                return new int[0];
            }
            int[] b = new int[sogiatritrunglap(a)]; int z = 0;
            int[] x = a; int i = 0;
            do
            {
                i = 0;
                if (x.Length == 0)
                    break;
                if (cotrunglapkhong(x, x[i]) == true)
                {
                    b[z] = x[i];
                    z++;
                    x = loaibophantu(x, x[i]);
                }
                else
                {
                    x = loaibophantu(x, x[i]);
                }

            }
            while (true);
            return b;
        }
        public static int[] loaibotrunglap(int[] a)
        {
            int[] b = giatritrunglap(a);
            for (int i = 0;i< b.Length; i++)
            {
                a = delai1gttrunglap(a, b[i]);
            }
            return a;
        }
        public static void Ex2()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            taomang(a);
            trungbinh(a);                                                           //1.
            inmang(a);
            Console.Write("Nhap gia tri muon kiem tra: ");                          //2.
            int gt= int.Parse(Console.ReadLine());
            int vitri = vitrigiatri(a, gt);                                         //3.
            if (cogiatrikhong(a, gt) == true)
            {
                Console.WriteLine("Co gia tri nay trong mang");
                Console.WriteLine($"Gia tri nay o vi tri {vitri} cua mang"); 
            }
            else Console.WriteLine("Khong co giá tri nay trong mang");
            Console.Write("Chon so ma ban muon loai bo: ");                         //4.
            int bo = int.Parse(Console.ReadLine());
            a = loaibophantu(a, bo);
            Console.Write("Mang moi la: "); inmang(a);
            int gtnn = min(a);                                                      //5.
            int gtln = max(a);
            Console.WriteLine(@$"Gia tri nho nhat cua mang la: {gtnn}
Gia tri lon nhat cua mang la: {gtln}");
            Console.WriteLine(@"Ban co muon dao nguoc mang khong?                  
Neu muon, nhan 'Y'; neu khong, nhan phim bat ky: ");                                //6.
            char option = char.Parse(Console.ReadLine());                           
            if (option == 'Y' || option == 'y')
            {
                daonguocmang(a);
                inmang(a);
            }
            int[] b = giatritrunglap(a);                                            //7.
            if (b.Length == 0)
            {
                Console.WriteLine("");
            }    
            else Console.Write("Cac gia tri bi trung lap la: "); inmang(b);
            Console.WriteLine(@"Ban co muon loai bo cac gia tri trung lap khong? 
Neu muon, nhan 'Y'; Neu khong, nhan phim bat ky: ");
            char luachon = char.Parse(Console.ReadLine());                           //8.
            if (luachon == 'Y' || luachon == 'y')
            {
                a=loaibotrunglap(a);
                inmang(a);
            }
        }
    }
}
