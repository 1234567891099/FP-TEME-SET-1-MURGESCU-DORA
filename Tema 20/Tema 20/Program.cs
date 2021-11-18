using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_20
{
    class Program
    {
        /// <summary>
        /// Afisati fractia m/n in format zecimal,
        /// cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
        /// </summary>
        static void Main(string[] args)
        {
            double f2, f5, fractie;
            double a, b;

            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());

            fractie = a / b;
            Console.Write($"Fractie este egala cu = {Math.Round(fractie, 2)} si aceasta este o ");

            if (a % b == 0)

                Console.Write("fractie finita");

            else
            {
                while (a % 2 == 0 && b % 2 == 0)
                {
                    a /= 2;
                    b /= 2;
                }
                while (a % 5 == 0 && b % 5 == 0)
                {
                    a /= 5;
                    b /= 5;
                }
                f2 = 0;
                while (b % 2 == 0)
                {
                    b /= 2;
                    ++f2;
                }
                f5 = 0;
                while (b % 5 == 0)
                {
                    b /= 5;
                    ++f5;
                }
                if (b == 1)
                    Console.Write("fractie finita");
                else
                {
                    if (a % b == 0)
                        Console.Write("fractie finita");
                    else
                    {
                        if (f2 == 0 && f5 == 0)
                            Console.Write("fractie periodica simpla");
                        else
                            Console.Write("fractie periodica mixta");

                    }
                }
            }
              Console.ReadKey();
        }
    }
}
        

