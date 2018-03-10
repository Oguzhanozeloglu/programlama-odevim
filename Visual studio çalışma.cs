using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4554148945
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İstiklal Marşı yazarımız kimdir? ");
                string cevap=Console.ReadLine();
            if (cevap=="Mehmet Akif Ersoy")
                Console.Write("Tebrikler! Doğru cevap");
            else
                Console.Write("Maalesef yanlış cevap");
            Console.ReadLine();
        }
    }
}
