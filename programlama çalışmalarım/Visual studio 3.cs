using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.WriteLine("Sayıyı Girniz..:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıyı2 Girniz..:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine("Sayı 1 Büyük");
            else
                Console.WriteLine("Sayı 2 Büyük");
            Console.ReadKey();
        }
    }
}
