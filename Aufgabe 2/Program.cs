using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viele Tage hat der Monat, für dne Sie die Sekundnezahl berechnen wollen ? ");
            int tage = Convert.ToInt32(Console.ReadLine());

            if (tage == 28 || tage == 29 || tage == 30 || tage == 31)
            {
                int sekunden = tage * 24 * 60 * 60;
                Console.WriteLine("Ein Monat mit " + tage + " Tagen hat " + sekunden + " Sekunden");
            }

            else

            {
                Console.WriteLine("Keine gültige Angabe!");
                }
        }
    }
}
