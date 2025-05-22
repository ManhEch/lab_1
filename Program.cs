using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1:");
            // Xuất thông tin lên màn hình
            Console.WriteLine("ID: " + UserData.ID);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Gold: " + UserData.Gold); // Đổi từ Health thành Gold
            Console.WriteLine("Point: " + UserData.Point);

            Console.WriteLine("Bai2:");
            var maps1 = new Maps("2024", "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps("2025", "ARAM");
            Console.WriteLine(maps2.ShowData());

            Console.WriteLine("Bai3:");
            Calculator calc = new Calculator(10, 5);
            Console.WriteLine($"Cộng: {calc.Add()}");
            Console.WriteLine($"Trừ: {calc.Subtract()}");
            Console.WriteLine($"Nhân: {calc.Multiply()}");
            Console.WriteLine($"Chia: {calc.Divide()}");



        }
        //Bai 1:
        public static class UserData
        {
            public static string ID;
            public static string UserName;
            public static float Gold;
            public static int Point;

            static UserData()
            {
                ID = "2024";
                UserName = "Hide on bush";
                Gold = 100.5f; // Đổi từ Health thành Gold
                Point = 100;
            }
        }

        //Bai 3:
        public partial class Calculator
        {
            public double A { get; set; }
            public double B { get; set; }

            public Calculator(double a, double b)
            {
                A = a;
                B = b;
            }
        }
        public partial class Calculator
        {
            public double Add() => A + B;
            public double Subtract() => A - B;
            public double Multiply() => A * B;
            public double Divide()
            {
                if (B != 0)
                    return A / B;
                else
                    throw new DivideByZeroException("Không thể chia cho 0!");
            }
        }



    }
}
