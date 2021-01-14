using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.upisKorisnika_dijeliviBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Unesite jedan broj: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 4 == 0)
            {
                Console.WriteLine("Vaš upisani broj dijeljiv je sa 4.");
            }

            if (n % 6 == 0)
            {
                Console.WriteLine("Vaš upisani broj dijeljiv je sa 6.");
            }

            if (n % 4 == 0 && n % 6 == 0)
            {
                Console.WriteLine("Vaš upisani broj dijeljiv je sa 4 i sa 6.");
            }
            if (n % 4 != 0 && n % 6 != 0)
            {
                Console.WriteLine("Vaš upisani broj nije dijeljiv sa 4 ni sa 6.");
            }

                Console.ReadKey();
        }
    }
}
