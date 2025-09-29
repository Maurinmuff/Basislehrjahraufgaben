using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the first number: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter the second number:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int summe = zahl1 + zahl2;

            Console.WriteLine("Die Summe ist:" + summe);

        }
    }
}
