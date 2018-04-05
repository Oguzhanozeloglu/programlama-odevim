using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            String ad;
            int adet = 0;
            Console.Write("Adınızı Griniz");
            ad = Console.ReadLine();
            Console.Write("Kaç Kere Tekrarlansın");
            adet = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<adet;i++)
            {
                Console.WriteLine(ad);
            }
            Console.ReadKey();

        }
    }
}
