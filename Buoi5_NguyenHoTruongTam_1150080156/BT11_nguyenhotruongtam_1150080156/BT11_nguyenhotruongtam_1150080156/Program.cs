using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT11_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Nhap mang tang dan:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhap so can chen x: ");
            int x = int.Parse(Console.ReadLine());

            int pos = Array.BinarySearch(a, x);
            if (pos < 0) pos = ~pos;

            int[] b = new int[n + 1];
            Array.Copy(a, 0, b, 0, pos);
            b[pos] = x;
            Array.Copy(a, pos, b, pos + 1, n - pos);

            Console.WriteLine("Mang sau khi chen:");
            Console.WriteLine(string.Join(" ", b));

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
