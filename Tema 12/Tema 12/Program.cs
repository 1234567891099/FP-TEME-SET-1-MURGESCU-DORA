using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_12
{
    class Program
    {
        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, n, contor = 0;

            Console.WriteLine("n= ");

            n = int.Parse(Console.ReadLine());
            Console.WriteLine("a= ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                {
                    if (i % n == 0)
                        contor++;
                }
            }
            Console.WriteLine($"In intervalul [{a},{b}] se afla {contor} numere intregi divizibile cu {n}");
        }
    }
}
