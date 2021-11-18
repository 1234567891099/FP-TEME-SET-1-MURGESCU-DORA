using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7
{
    /// <summary>
    /// Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
    /// Se cere sa se inverseze valorile lor. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, swap;

            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valorile inainte de inversare sunt {a} {b}");

            swap = a;

            a = b;

            b = swap;

            Console.WriteLine($"Valorile dupa inversare sunt {a} {b}");
        }
    }
}
