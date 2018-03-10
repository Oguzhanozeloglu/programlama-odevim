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
            Console.Write("Bir Sayı giriniz: ");
            Double sayı = Convert.ToDouble(Console.ReadLine());
            if ((sayı % 3 == 0) && (sayı % 5 == 0))
                Console.WriteLine("{0} sayısı hem 3'e hem 5'kalansız bölünebilir", sayı);
            Console.WriteLine("{0} sayısı hem 3'e hem 5'e kalansız bölünebilir", sayı);
            Console.ReadKey();
        }
    }
}
