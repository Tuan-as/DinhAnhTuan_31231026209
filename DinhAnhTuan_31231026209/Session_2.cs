using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhAnhTuan_31231026209
{
    internal class Session_2
    {

          public static void Main2()
    {
        Q1();
        Q2();
        Q3();
        Q4();
        Q5();
        Q6();
        Q7();
        Q8();
        Q9();
        Q10();


    }

    /// <summary>
    /// 1.to Add/Sum Two number
    /// </summary>
    public static void Q1()
    {
        Console.Write("Hay nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Hay nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine($"Tong cua {a} va {b} la {sum}");
    }
    /// <summary>
    /// 2.to Swap Values of Two Variable
    /// </summary>
    public static void Q2()
    {
        Console.Write("Hay nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Hay nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a;
        a = b; b = c;
        Console.WriteLine($"a bay gio la {a}, b bay gio la {b}");
    }
    /// <summary>
    /// 3.to Multiply two floating point number
    /// </summary>
    public static void Q3()
    {
        Console.Write("Hay nhap so thap phan thu nhat: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Hay nhap so thap phan thu hai: ");
        double b = double.Parse(Console.ReadLine());
        double tich = a * b;
        Console.WriteLine($"tich cua hai so thap phan {a}, {b} la {tich}");
    }
    /// <summary>
    /// 4.to convert feet to meter
    /// </summary>
    public static void Q4()
    {
        Console.Write("Do dai theo don vi feet: ");
        double a = double.Parse(Console.ReadLine());
        double doidonvi = 0.305;
        double meter = a * doidonvi;
        Console.WriteLine($"Do dai theo don vi meter: {meter}");
    }
    /// <summary>
    /// 5.to convert Celcius to Fahrenheit and vice versa
    /// </summary>
    public static void Q5()
    {
        Console.Write("Dien C de doi tu Celcius thanh Fahrenheit, Dien F de doi tu Fahrenheit thanh Celcius: ");
        string donvi = Console.ReadLine();
        if (donvi == "C")
        {
            Console.Write("Nhap nhiet do Celcius: ");
            double nhietdoC = double.Parse(Console.ReadLine());
            double nhietdoF = nhietdoC * (9 / 5) + 32;
            Console.WriteLine($"Nhiet do Fahrenheit la: {nhietdoF}");
        }
        else
        {
            Console.Write("Nhap nhiet do Fahrenheit: ");
            double nhietdoF = double.Parse(Console.ReadLine());
            double nhietdoC = (nhietdoF - 32) / (9 / 5);
            Console.WriteLine($"Nhiet do Celcius la: {nhietdoC}");
        }
    }
    /// <summary>
    /// 6.to find the size of data type
    /// </summary>
    public static void Q6()
    { 
        int x = sizeof(int);
        Console.WriteLine($"Do lon cua kieu int la: {x}");
    }
    /// <summary>
    /// 7.to print ASCII Value
    /// </summary>
    public static void Q7()
    {
        Console.WriteLine("Nhap ki tu: ");
        char kitu = Console.ReadKey().KeyChar;
        int gtascii = (int)kitu;
        Console.WriteLine($"Gia tri ASCII cua '{kitu}' la {gtascii}");
    }
    /// <summary>
    /// 8.to Calculate Area of circle
    /// </summary>
    public static void Q8()
    {
        Console.Write("Nhap ban kinh cua duong tron: ");
        double r = double.Parse(Console.ReadLine());
    double S = Math.PI * r * r;
    Console.WriteLine($"Dien tich cua duong tron co ban kinh {r} la {S}");
    }
    /// <summary>
    /// 9.to calculate Area of Sphere
    /// </summary>
    public static void Q9()
    {
    Console.Write("Nhap ban kinh cua hinh cau: ");
    double r = double.Parse(Console.ReadLine());
    double S = Math.PI *4* r * r;
    Console.WriteLine($"Dien tich cua hinh cau ban kinh {r} la {S}");
    }
    /// <summary>
    /// 10.to convert days to years, weeks and days
    /// </summary>
    public static void Q10()
    {
    Console.Write("Hay nhap so ngay: ");
    int songay = int.Parse(Console.ReadLine());
    int nam = songay / 365;
    int tuan = (songay - nam * 365) / 7;
    int ngayle = (songay - nam * 365) % 7;
    Console.WriteLine($"{songay} ngay tuong ung voi {nam} nam, {tuan} tuan, {ngayle} ngay.");
    }
    }
}
