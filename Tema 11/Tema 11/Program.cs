using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_11
{
    class Program
    {
        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                Console.Write(n % 10 + " ");

                n = n / 10;
            }
        }
    }
}
