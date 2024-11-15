using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DinhAnhTuan_31231026209
{
    internal class session_7
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            Ex2jagged();
        }
        /// <summary>
        /// Create an integermatrix N x M (N,M was prompted from user) randomly.
        /// </summary>
        public static int[,] Taomang2chieu()
        {
            int[,] a;
            Random r = new Random();
            Console.Write("Nhap so dong cua mang: "); int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua mang: "); int col = int.Parse(Console.ReadLine());
            a = new int[row, col];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(100);
                }
            }
            return a;
        }
        public static void Ex1()
        {
            Taomang2chieu();
        }
        /// <summary>
        /// Print the matrix
        /// </summary>
        public static void inmang2chieu(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}    ");
                }
                Console.WriteLine();
            }
        }
        public static void Ex2()
        {
            inmang2chieu(Taomang2chieu());
        }
        /// <summary>
        /// Print the ith row/column. (i was prompted from user)
        /// </summary>
        public static void incot(int[,] a, int cot)
        {
            if (cot < 0 || cot > a.GetLength(1) - 1)
            {
                Console.WriteLine("Hay nhap dung so");
                return;
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine($"{a[i, cot]}");
            }
        }
        public static void indong(int[,] a, int dong)
        {
            if (dong < 0 || dong > a.GetLength(0) - 1)
            {
                Console.WriteLine("Hay nhap dung so");
                return;
            }
            for (int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[dong, i]}  ");
            }
        }
        public static void Ex3()
        {
            int[,] a = Taomang2chieu();
            Console.Write(@"Ban muon in cot hay dong?
Neu in cot nhan 'c', neu in dong nhan 'd'. 
Neu khong in cot hay dong nhan phim bat ki.
");
            char kt = char.Parse(Console.ReadLine());
            if (kt == 'C' || kt == 'c')
            {
                Console.WriteLine("Nhap so cot muon in:"); int cot = int.Parse(Console.ReadLine());
                incot(a, cot);
            }
            else if (kt == 'd' || kt == 'D')
            {
                Console.WriteLine("Nhap so dong muon in:"); int dong = int.Parse(Console.ReadLine());
                indong(a, dong);
            }
        }
        /// <summary>
        /// Find the max value of the matrix
        /// </summary>
        public static int gtlnmatran(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    { max = a[i, j]; }
                }
            }
            return max;
        }
        public static void Ex4()
        {
            int[,] a = Taomang2chieu();
            inmang2chieu(a);
            int max = gtlnmatran(a);
            Console.WriteLine($"Gia tri lon nhat cua ma tran la: {max}");
        }
        /// <summary>
        /// Find the min value of ith row/col of the matrix.

        /// </summary>
        public static int gtnncot(int[,] a, int cot)
        {
                int min = a[0, cot];
            for (int i = 0; i < a.GetLength(0); i++)
            {        
                    if (a[i, cot] <min)
                    { min = a[i, cot]; }
            }
            return min;
        }
        public static int gtnndong(int[,] a, int dong)
        {
            int min = a[dong, 0];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                if (a[dong, i] < min)
                { min = a[i, dong]; }
            }
            return min;
        }
        public static void Ex5()
        {
            int[,] a = Taomang2chieu();
            Console.Write(@"Ban muon tim gtnn o cot hay dong?
Neu in cot nhan 'c', neu in dong nhan 'd'. 
Neu khong muon tim gtnn, nhan phim bat ki.
");
            char kt = char.Parse(Console.ReadLine());
            if (kt == 'C' || kt == 'c')
            {
                Console.WriteLine("Nhap so cot muon tim gtnn:"); int cot = int.Parse(Console.ReadLine());
                if (cot < 0 || cot > a.GetLength(1) - 1)
                {
                    Console.WriteLine("Hay nhap dung so");
                    return;
                }
                gtnncot(a, cot);
            }
            else if (kt == 'd' || kt == 'D')
            {
                Console.WriteLine("Nhap so dong muon in:"); int dong = int.Parse(Console.ReadLine());
                if (dong < 0 || dong > a.GetLength(0) - 1)
                {
                    Console.WriteLine("Hay nhap dung so");
                    return;
                }
                gtnndong(a, dong);
            }
        }
    
        /// <summary>
        /// Transpose the matrix.
        /// </summary>
        public static int[,] chuyenvi(int[,] a)
        {
            int[,] b = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j,i] = a[i, j];
                }
            }
            return b;
        }
        public static void Ex6()
        {
            int[,] a = Taomang2chieu();
            inmang2chieu(a);
            Console.WriteLine();
            a = chuyenvi(a);
            Console.WriteLine("Mang da duoc chuyen vi:");
            inmang2chieu(a);
        }
        /// <summary>
        /// Print the main/secondarydiagonal values of the matrix.
        /// </summary>
        public static void Ex7()
        {
            int[,] a = Taomang2chieu();
            inmang2chieu(a);
            Console.WriteLine();
            if (a.GetLength(0) == a.GetLength(1))
            {
                Console.WriteLine("Duong cheo chinh");
                incgcheochinh(a); Console.WriteLine();
                Console.WriteLine("Duong cheo phu");
                indgcheophu(a); Console.WriteLine();
            }
            else Console.WriteLine("Khong the in duong cheo");
        }

        private static void indgcheophu(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i,a.GetLength(1)-1-i]}   ");
            }
        }

        private static void incgcheochinh(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i,i]}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Ex1jagged()
        {

        }
        public static void Ex2jagged()
        {
            Random random = new Random();
            Console.WriteLine("Nhap so hang cua mang jagged: "); int hang = int.Parse(Console.ReadLine());
            int[][] a = new int[hang][];
            for (int i = 0;i < a.Length;i++)
            {
                Console.WriteLine($"Nhap so cot cua hang {i}: ");
                int cot = int.Parse(Console.ReadLine());
                for (int j = 0;j < cot;j++) 
                { 
                    a[i][j] = random.Next(100);
                }
            }


        }
    }
}
