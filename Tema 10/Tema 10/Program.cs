using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_10
{
    /// <summary>
    /// Test de primalitate: determinati daca un numar n este prim.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());

            if (prim(n))
            {
                Console.WriteLine($"Numarul {n} este prim");
            }

            else
            {
                Console.WriteLine($"Numarul {n} nu este prim");
            }
        }
        private static bool prim(int n)
        {
            if (n < 2)
            {
                return false;
            }
               
            if (n % 2 == 0)
            {
                return false;

            }
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }  
            }

            return true;
        }
    }
}


