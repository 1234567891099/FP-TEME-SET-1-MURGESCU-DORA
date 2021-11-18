using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{
    class Program
    {
        /// <summary>
        /// Detreminati daca un an y este an bisect. 
        /// </summary>
        static void Main(string[] args)
        {
            int an;

            Console.Write("an= ");

            an = int.Parse(Console.ReadLine());

            if (an % 400 == 0)
            {
                Console.Write("Este an bisect");
            }
            else if (an % 100 == 0)
            {
                Console.Write("Nu este an bisect");
            }
            else if (an % 4 == 0)
            {
                Console.Write("Este an bisect");
            }
            else
            {
                Console.Write("Nu este an bisect");

            }
            Console.ReadLine();
        }
    }
}
