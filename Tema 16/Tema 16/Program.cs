using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_16
{
    class Program
    {
        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, c, d, e, aux;

            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("c= ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("d= ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("e= ");
            e = int.Parse(Console.ReadLine());

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
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                aux = a;
                a = e;
                e = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt {a} {b} {c} {d} {e}");
        }
    }
}
