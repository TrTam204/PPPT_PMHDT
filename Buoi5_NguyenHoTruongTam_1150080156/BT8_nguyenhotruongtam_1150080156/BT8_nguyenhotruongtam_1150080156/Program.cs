using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT8_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            const double EPS = 1e-12;

            if (Math.Abs(a) < EPS)
            {
                if (Math.Abs(b) < EPS)
                {
                    Console.WriteLine(Math.Abs(c) < EPS ? "Vo so nghiem" : "Vo nghiem");
                }
                else
                {
                    Console.WriteLine($"Phuong trinh co 1 nghiem: x = {-c / b}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < -EPS)
                {
                    Console.WriteLine("Phuong trinh vo nghiem thuc");
                }
                else if (Math.Abs(delta) <= EPS)
                {
                    Console.WriteLine($"Phuong trinh co nghiem kep: x = {-b / (2 * a)}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1}, x2 = {x2}");
                }
            }

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
