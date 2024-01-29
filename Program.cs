using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizovi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neparniNiz = new int[10];
            int[] parniNiz = new int[10];
            int neparniBrojac = 0;
            int parniBrojac = 0;

            while (true)
            {
                Console.Write("Unesite broj: ");
                int broj = int.Parse(Console.ReadLine());

                if (broj == 0 || neparniBrojac + parniBrojac >= 10)
                {
                    break;
                }

                if (broj % 2 == 0)
                {
                    parniNiz[parniBrojac] = broj;
                    parniBrojac++;
                }
                else
                {
                    neparniNiz[neparniBrojac] = broj;
                    neparniBrojac++;
                }
            }

            Console.WriteLine("Neparni brojevi:");
            for (int i = 0; i < neparniBrojac; i++)
            {
                Console.WriteLine(neparniNiz[i]);
            }

            Console.WriteLine("Parni brojevi:");
            for (int i = 0; i < parniBrojac; i++)
            {
                Console.WriteLine(parniNiz[i]);
            }

            Console.ReadKey();  
        }
    }
}
