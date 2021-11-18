using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_15
{
    /// <summary>
    /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, aux;

            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt {a} {b} {c}");
        }
    }
}
