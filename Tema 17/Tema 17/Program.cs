using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_17
{
    class Program
    {
        /// <summary>
        ///  Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
        ///  Folositi algoritmul lui Euclid. 
        /// </summary>
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a= ");

            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cel mai mare divizor comun dintre {a} si {b} este {Euclid(a, b)}");

            Console.WriteLine();

            Console.WriteLine($"Cel mai mare multiplu comun dintre {a} si {b} este {CMMC(a, b)}");
        }

        static int Euclid(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        static int CMMC(int a, int b)
        {
            int n = a, m = b;
            while (m != n)
            {
                if (n < m)
                    n = n + a;
                if (n > m)
                    m = m + b;
            }
            return n;
        }
    }
}

