using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, toplam = 0;
            for (i = 0; i <= 100; i++)
            {
                toplam = toplam + i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Sayıların toplamı :" + toplam);
            Console.ReadKey();
        }
    }
}
