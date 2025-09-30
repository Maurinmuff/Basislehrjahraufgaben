using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Bitte gib eine positive Ganzzahl ein: ");
                int zahl = int.Parse(Console.ReadLine());

                int quersumme = BerechneQuersumme(zahl);
                Console.WriteLine("Die Quersumme von " + zahl + " ist: " + quersumme);
            }
        }
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;



            }
            return sum;
        }


    }
}
