using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_18
{
    class Program
    {
        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n. 
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            descompPrim(n);
        }

        static void descompPrim(int n)
        {
            int p, d = 2;
            Console.Write($"Numarul {n} se descompune astfel: ");
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p > 0)
                    Console.Write($"{d}^{p} x ");
                d++;
                if (n > 1 && d * d > n)
                    d = n;

            }
        }
    }
}
