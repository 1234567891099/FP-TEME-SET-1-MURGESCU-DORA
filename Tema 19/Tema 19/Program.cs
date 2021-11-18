using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_19
{
    /// <summary>
    /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            verif(n);
        }

        static void verif(int n)
        {
            int a = 0, b = 0, i = 0, copie;
            bool ok = true;
            copie = n;

            while (n > 9)
            {
                if (n % 10 != (n / 10) % 10)
                {
                    a = n % 10;
                    b = (n / 10) % 10;
                    n = n / 100;
                    i = n % 10;
                }
                if (i != a && i != b)
                    ok = false;
                n = n / 10;

            }
            if (ok == true)

                Console.WriteLine($"Numarul {copie} e format doar cu 2 cifre care se pot repeta");

            else

                Console.WriteLine($"Numarul {copie} nu e format doar cu 2 cifre care se pot repeta");
        }
    }
}
