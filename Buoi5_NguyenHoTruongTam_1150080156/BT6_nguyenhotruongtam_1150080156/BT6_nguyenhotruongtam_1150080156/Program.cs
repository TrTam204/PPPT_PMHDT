using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai a (>0): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong b (>0): ");
            double b = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("a, b!");
                return;
            }

            double P = 2 * (a + b);
            double S = a * b;
            Console.WriteLine($"P = {P}, S = {S}");
        }
    }
}
