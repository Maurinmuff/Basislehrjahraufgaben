using System;

class Program
{
    static void Main()
    {
        Console.Write("Bitte eine Zahl zwischen 1 und 12 eingeben: ");
        string eingabe = Console.ReadLine();

        
        if (int.TryParse(eingabe, out int zahl))
        {
            switch (zahl)
            {
                case 1: Console.WriteLine("Januar"); break;
                case 2: Console.WriteLine("Februar"); break;
                case 3: Console.WriteLine("März"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("Mai"); break;
                case 6: Console.WriteLine("Juni"); break;
                case 7: Console.WriteLine("Juli"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("Oktober"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("Dezember"); break;
                default:
                     
                Console.WriteLine("Das ist keine gültige Eingabe (nur 1-12 erlaubt).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe, bitte eine Zahl eingeben.");
        }

        Console.WriteLine("Programm beendet. Drücke eine Taste zum Schließen...");
        Console.ReadKey();
    }
}
