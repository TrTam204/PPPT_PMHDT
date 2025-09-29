using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            // Kiem tra chan le
            if (n % 2 == 0)
                Console.WriteLine("n la so CHAN");
            else
                Console.WriteLine("n la so LE");

            // Kiem tra am duong
            if (n > 0)
                Console.WriteLine("n la so KHONG AM");
            else if (n < 0)
                Console.WriteLine("n la so AM");
            else
                Console.WriteLine("n bang 0 (KHONG AM VA KHONG DUONG)");

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
