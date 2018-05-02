using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            while(sayı>=0)
            {
                Console.WriteLine(sayı);
                System.Threading.Thread.Sleep(100);
                sayı--;
            }
            Console.ReadKey();
        }
    }
}
