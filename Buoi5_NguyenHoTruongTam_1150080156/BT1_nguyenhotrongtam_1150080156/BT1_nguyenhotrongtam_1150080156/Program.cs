using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_nguyenhotrongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.Write("Nhap chieu dai a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong b: ");
                double b = double.Parse(Console.ReadLine());

                double P = 2 * (a + b);
                double S = a * b;

                Console.WriteLine($"Chu vi P = {P}");
                Console.WriteLine($"Dien tich S = {S}");
            }
    }
}
