using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            while (sayi <= 100)
            {
                if (sayi % 2 == 1)
                    toplam += sayi;
                sayi++;
            }
            Console.WriteLine("Tek sayıların toplamı:" + toplam);
            Console.ReadKey();
        }
    }
}
