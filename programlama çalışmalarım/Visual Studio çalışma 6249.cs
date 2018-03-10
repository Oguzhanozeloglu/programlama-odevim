using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme123456789
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 6;
            int sayı2 = 5;
            int sayı3 = 11;
            if(sayı1==sayı2){
                Console.WriteLine("sayı 1 ile sayı 2 birbirine eşit");
            }
            else if (sayı1+sayı2 == sayı3){
                Console.WriteLine("sayı 1 ile 2 toplamı sayı 3 e eşit ");
            }
            else{
                Console.WriteLine("Hiç eşitlik yok");
            }
            Console.ReadKey();
            }
    }
}
