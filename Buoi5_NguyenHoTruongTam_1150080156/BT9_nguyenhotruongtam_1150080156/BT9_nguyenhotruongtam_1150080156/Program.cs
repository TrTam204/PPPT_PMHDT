using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT9_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            long sum = 0;
            for (int i = 0; i < n; i++) sum += a[i];

            Console.WriteLine($"Tong cac phan tu = {sum}");

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
