using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_8
{
    /// <summary>
    /// Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
    /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a={0}, b={1}", a, b);

            a = b;
            Console.WriteLine($"{a} ia valuarea lui {b}");
            b = a;
            Console.WriteLine($"{b} ia valoarea lui {a}");

        }
    }
}