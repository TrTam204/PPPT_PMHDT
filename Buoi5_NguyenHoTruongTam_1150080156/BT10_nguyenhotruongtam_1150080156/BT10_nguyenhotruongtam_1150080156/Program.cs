using System;
using System.IO;    
using System.Linq;

namespace BT10_nguyenhotruongtam_1150080156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "input_array.txt";
                var nums = File.ReadAllText(path)
                               .Split(new[] { ' ', '\n', '\r', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

                SelectionSort(nums);

                Console.WriteLine("Mang sau khi sap xep tang dan:");
                Console.WriteLine(string.Join(" ", nums));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
                Console.WriteLine("Hay tao file input_array.txt cung thu muc voi file .exe (bin/Debug...).");
            }

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
        static void SelectionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[minIdx]) minIdx = j;

                if (minIdx != i)
                {
                    int tmp = a[i]; a[i] = a[minIdx]; a[minIdx] = tmp;
                }
            }
        }
    }
}
