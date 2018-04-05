using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DENEME.CS_123456789
{
    class Program
    {
        static void Main(string[] args)
        {
            int tektoplam = 0, cifttoplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1) tektoplam += i;

                else cifttoplam += i;

            }

            Console.WriteLine("Tek Sayıların Toplamı = {0}", tektoplam);

            Console.WriteLine("Çift Sayıların Toplamı = {0}", cifttoplam);
            Console.ReadKey();
        }
    }
}
