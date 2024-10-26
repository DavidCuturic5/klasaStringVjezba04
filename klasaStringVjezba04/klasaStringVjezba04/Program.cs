using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string unos = Console.ReadLine();

            string[] riječi = unos.Split(' ');
            string prvariječ = riječi[0];
            string zadnjariječ = riječi[riječi.Length - 1];

            Console.WriteLine("Prva riječ je:" + prvariječ);
            Console.WriteLine("Zadnja riječ je:" + zadnjariječ);




            Console.ReadKey();
        }
    }
}
