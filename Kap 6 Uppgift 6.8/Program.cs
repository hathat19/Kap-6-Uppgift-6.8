using System;
using System.Collections.Generic;
namespace Uppgift6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int userInt = ReadInt();
            HurMångaPrimtalInnanZ(userInt);
        }

        /// <summary>
        /// Undersöker om en int är ett primtal eller inte.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True/False</returns>
        static bool PrimtalEllerInte(int x)
        {
            x = Math.Abs(x);

            for (int i = 0; i < x; i++)
            {
                if (i == 0 || i == x - 1) continue;
                else if (x % (i + 1) == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Beräknar hur många primtal det finns innan ett visst tal. 
        /// </summary>
        /// <param name="z"></param>
        static void HurMångaPrimtalInnanZ(int z)
        {
            int nrOfPrimesBeforeZ = 0;
            List<int> primesBeforeZ = new List<int>();

            for (int i = 2; i < z; i++)
            {
                if (PrimtalEllerInte(i))
                {
                    nrOfPrimesBeforeZ++;
                    primesBeforeZ.Add(i);
                }
            }

            Console.WriteLine($"Det finns {nrOfPrimesBeforeZ} primtal innan {z}.");
            if (nrOfPrimesBeforeZ != 0)
            {
                Console.WriteLine("De inkluderar:");
                foreach (int prime in primesBeforeZ)
                {
                    Console.WriteLine(prime);
                }
            }
            
        }

        static int ReadInt()
        {
            int integer;
            while (int.TryParse(Console.ReadLine(), out integer) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return integer;
        }
    }
}
/*Skapa ett program som frågar användaren efter ett heltal. Programmet ska sedan,
med hjälp av en metod, beräkna hur många primtal som är mindre än det heltal som
användaren skrev in. Metoden som beräknar antalet primtal ska använda sig av
metoden du skrev i den föregående uppgiften som undersöker om ett tal är ett primtal
eller inte.*/