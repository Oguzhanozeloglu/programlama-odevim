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
            for (int i = 10; i >=1;i--)
            {
             for (int k = 1 ; k <= i;k++)
                {
            Console.Write("*") ;
                }
        Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
