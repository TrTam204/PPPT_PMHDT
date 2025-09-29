using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang (1-12): ");
            int month = int.Parse(Console.ReadLine());

            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30; break;
                case 2:
                    bool leap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
                    days = leap ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Thang khong hop le!");
                    return;
            }
            Console.WriteLine($"Thang {month}/{year} co {days} ngay.");
        }
    }
}
