using System;

class Program
{
    static void Main()
    {
        string[] forbiddenWords = {   "viagra", "sex", "porno", "fick", "schlampe", "arsch",
            "wichser", "fotze", "hure", "nutte", "bastard", "dummkopf",
            "penis", "vagina", "muschi", "dildo", "hurensohn", "idiot",
            "miststück", "pisser", "schwein", "sau", "arschloch", "trottel",
            "verpiss", "scheiße", "scheisse", "fuck", "motherfucker", "loser",
            "slut", "dumbass", "crap", "bitch", "gaylord", "pimmel", "kacke",
            "spasti", "mongo", "depp", "blödmann", "affenarsch", "opfer", "neger" };

       
        Console.Write("Bitte geben Sie einen Kommentar ein: ");
        string comment = Console.ReadLine();

        
        string lowerComment = comment.ToLower();

        int foundCount = 0;

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (lowerComment.Contains(forbiddenWords[i]))
            {
                foundCount++;
            }
        }

        if (foundCount > 0)
        {
            Console.WriteLine("🚫 Kommentar wird nicht veröffentlicht.");
            Console.WriteLine("Gefundene verbotene Wörter: " + foundCount);
        }
        else
        {
            Console.WriteLine("✅ Ein schöner Kommentar ohne Böswilligkeiten.");
        }
    }
}
