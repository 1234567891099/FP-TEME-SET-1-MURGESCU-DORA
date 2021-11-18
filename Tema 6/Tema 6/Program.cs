using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_6
{
    class Program
    {
        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("c= ");
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"{a}, {b}, {c} pot fi lungimile laturilor unui triunghi");
            }

            else
            {
                Console.WriteLine($"{a}, {b}, {c} nu pot fi lungimile laturilor unui triunghi");
            }
        }
    }
}
