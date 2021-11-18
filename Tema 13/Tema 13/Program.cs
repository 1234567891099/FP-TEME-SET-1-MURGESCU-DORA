using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_13
{
    /// <summary>
    /// Determianti cati ani bisecti sunt intre anii y1 si y2.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, aux, contor = 0;
            Console.WriteLine("Primul an= ");

            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Al doilea an= ");

            y2 = int.Parse(Console.ReadLine());

            if (y1 > y2)
            {
                aux = y1;
                y1 = y2;
                y2 = aux;
            }

            for (int i = y1; i <= y2; i++)
            {
                if (i % 4 == 0 || i % 400 == 0)
                    contor++;
            }

            Console.WriteLine($"Intre anii {y1} si {y2} sunt {contor} ani bisecti");
        }
    }
}
