using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DinhAnhTuan_31231026209
{
    internal class session_5
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4c1();
            //Ex4c2();
            Ex5();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int Max(int a ,int b, int c)
        {
            int max;
            if (a > b)
                max = a;
            else max = b;
            if (c>max)
                max = c;
            Console.WriteLine($"max={max}");
            return max;
        }
        public static void Ex1()
        { 
            int a = 1; int b = 2; int c = 3;
            Max(a, b, c);
        }
        /// <summary>
        /// Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        /// 
        public static int Factorial(int a)
        {
            int fac = 1;
            for (int i = 1; i <= a; i++)
                fac *= i;
            return fac;
        }
        public static void Ex2()
        {
            Console.Write("Nhap so can tinh giai thua: ");
            int a = int.Parse(Console.ReadLine());
            int giaithua=Factorial(a);
            Console.WriteLine(giaithua);
        }

        /// <summary>
        /// Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        public static bool Primeornot(int a)
        {
            int uoc = 0;
            for (int i = 1;i <= a; i++)
                if (a%i==0)
                    uoc++;
            if (uoc == 2)
                return true;
            else return false;
        }
        public static void Ex3()
        {
            Console.Write("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            bool x=Primeornot(a);
            Console.WriteLine(x);
        }

        /// <summary>
        /// all prime numbers that less than a number (enter prompt keyboard).
        /// </summary>
        public static int cacsongtotruocN(int a)
        {
            for (int j=1;j<=a;j++)
                if (Primeornot(j) == true)
                    Console.WriteLine(j);
            return a;
        }
        public static void Ex4c1()
        {
            Console.Write("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            cacsongtotruocN(a);
        }

        /// <summary>
        /// the first N prime numbers
        /// </summary>
        public static int Nsongtodau(int a)
        {
            do
            {
                int count = 0;
                for (int j = 1; j >= 1; j++)
                    if (Primeornot(j) == true)
                    {
                        Console.WriteLine(j);
                        count++;
                        if (count == a)
                            break;
                    }
                break;
            }
            while (true);
            return a;
        }
        public static void Ex4c2() 
        {
            Console.Write("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            Nsongtodau(a);
        }

        /// <summary>
        /// Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        public static bool coperfectko(int a)
        {
            int sum = 0;
            for (int i = 1; i <= a/2; i++)
                if (a % i == 0)
                    sum += i;
            if (sum == a)
                return true;
            else return false;
        }
        public static int insoperfect(int a)
        {
            for (int i = 1; i <=a;i++)
                if (coperfectko(i) == true)
                    Console.WriteLine(i);
            return a;
        }
        public static void Ex5()
        {
            insoperfect(1000);
        }

        /// <summary>
        /// Write a C# function to check whether a string is a pangram or not.
        /// </summary>
        public static bool cophaipangram(string a)
        {
            foreach (char c in a)
            {
                if (
            }    
        }
        public static void Ex6()
        {

        }
    }
}
