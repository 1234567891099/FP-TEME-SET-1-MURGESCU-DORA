using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_9
{
    class Program
    {
        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Divizorii lui {n} sunt: ");

            Console.Write(1 + " ");

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i + " ");
            }
               
        }
    }
}
