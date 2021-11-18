using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_14
{
    /// <summary>
    /// Determianti daca un numar n este palindrom.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            if (n == oglindit(n))
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }

        static int oglindit(int n)
        {
            int og = 0;
            while (n != 0)
            {
                og = og * 10 + n % 10;
                n = n / 10;
            }
            return og;

        }

	}
}
