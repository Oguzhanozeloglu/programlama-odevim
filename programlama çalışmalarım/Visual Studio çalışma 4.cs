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
            char cinsiyet;
            int yas;
            Console.Write("lütfen cinsiyetinizi giriniz (E/K):");
            cinsiyet=Convert.ToChar(Console.ReadLine());
            Console.Write("Lütfen yaşınızı giriniz:");
            yas = Convert.ToInt32(Console.ReadLine());
                if (((cinsiyet == 'E') || (cinsiyet == 'e')) && (yas >= 20))
                {
                    Console.WriteLine("Askere gidebilir");
                }
                else
                {
                    Console.WriteLine("Askere gidemez");
                }
            Console.ReadKey();


        }
    }
}
