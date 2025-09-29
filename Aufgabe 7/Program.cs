using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Zahlen von 1 bis 30, die durch 3 oder 5 teilbar sind:");
            {
                for (int i = 1; i <= 30; i++)
                {
                    
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                       
                        if (i == 30)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(i + ", ");
                        }
                    }
                }

                Console.WriteLine(); 
            }
        }



    }
}

