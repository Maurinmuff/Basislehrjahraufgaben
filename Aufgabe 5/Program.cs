using System;

class Program
{
    static void Main()
    {
        Console.Write("Wie viele Kilometer möchtest du rennen? ");

   
        if (!double.TryParse(Console.ReadLine(), out double km))
        {
            Console.WriteLine("Ungültige Eingabe!");
            return;
        }

        
        if (km > 42)
        {
            Console.WriteLine("Das schaffst du nicht!");
            return;
        }

        int runden = (int)Math.Ceiling(km / 0.4);

        Console.WriteLine($"Das sind {runden} Runden. Bereit für den Lauf? (j/n)");
        string bereit = Console.ReadLine()?.ToLower();

        if (bereit != "j")
        {
            Console.WriteLine("Okay, vielleicht ein andermal.");
            return;
        }

       
        int i = 1;
        while (i <= runden)
        {
            Console.WriteLine($"Du läufst Runde {i}.");
            i++;
        }

       
        Console.WriteLine("Du hast es geschafft!");
    }
}
