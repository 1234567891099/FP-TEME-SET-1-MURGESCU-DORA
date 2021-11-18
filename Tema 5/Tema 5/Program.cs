using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    /// <summary>
    /// Extrageți și afișați a k-a cifră de la sfârșitul unui număr. 
    /// Cifrele se numară de la dreapta la stânga. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, contor = 0, cifra = 0;
            Console.WriteLine("n= ");

            n = int.Parse(Console.ReadLine());
            Console.WriteLine("k= ");

            k = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                contor++;

                if (contor == k)

                    cifra = n % 10;
                n = n / 10;
            }

            Console.WriteLine($"Cifra extrasa este: {cifra}");
        }
    }
}


