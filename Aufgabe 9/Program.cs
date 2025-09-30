using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Gib eine positive Ganzzahl ein (oder 'q' zum Beenden): ");
                string eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "q")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }

              
                if (int.TryParse(eingabe, out int zahl) && zahl > 0)
                {
                    string binaer = DezimalZuBinaer(zahl);
                    Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + binaer);
                }
                else
                {
                    Console.WriteLine("Bitte gib eine positive Ganzzahl oder 'q' ein!");
                }
            }
        }

        static string DezimalZuBinaer(int zahl)
        {
            StringBuilder sb = new StringBuilder();

            while (zahl > 0)
            {
                int rest = zahl % 2;
                sb.Insert(0, rest);
                zahl = zahl / 2;
            }

            return sb.ToString();



        }
    }
}
