using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithme_récursif
{
    internal class Program
    {
        static int recursif(int bn)
        {
            if (bn == 0) 
            { 
                return 1; 
            } 
            else 
            { 
                return bn * recursif(bn - 1); 
            }
        }
           
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Saisie un entier");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La factorielle de n est {0} ",recursif(a));
            Console.ReadKey();
        }
    }
}
