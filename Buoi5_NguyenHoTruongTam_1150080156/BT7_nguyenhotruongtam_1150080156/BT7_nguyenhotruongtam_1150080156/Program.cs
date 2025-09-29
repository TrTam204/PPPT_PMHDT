using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap canh a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap canh b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap canh c: ");
            double c = double.Parse(Console.ReadLine() ?? "0");

            // Kiem tra dieu kien tam giac
            bool isTriangle = a > 0 && b > 0 && c > 0 &&
                              a + b > c && a + c > b && b + c > a;

            if (!isTriangle)
            {
                Console.WriteLine("BA CANH KHONG TAO THANH MOT TAM GIAC");
            }
            else
            {
                Console.WriteLine("BA CANH TAO THANH MOT TAM GIAC");

                double P = a + b + c;
                double p = P / 2.0;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Chu vi P = {P}");
                Console.WriteLine($"Dien tich S = {S}");
            }

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
 
}
