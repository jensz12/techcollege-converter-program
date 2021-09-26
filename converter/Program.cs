using System;

namespace converter
{
    class Program
    {
        static Double ReadDouble(string tekst)
        {
            Console.Write(tekst);
            String input = Console.ReadLine();
            double valu = Convert.ToDouble(input);
            return valu;
        }

        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Omergen og Lomeregner");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Lommeregner");
            Console.WriteLine("2. Omregner");
            Console.WriteLine("---------------------");
            Console.Write("Vælg funktion: ");
            String input = Console.ReadLine();

            if (input == "1" || input == "Lomeregner")
            {

                double resultat = 0;
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Træk fra");
                Console.WriteLine("3. Gange");
                Console.WriteLine("4. Dividere");
                Console.WriteLine("---------------------");
                Console.Write("Vælg funktion: ");
                input = Console.ReadLine();

                Double tal1 = ReadDouble("Tal 1: ");
                Double tal2 = ReadDouble("Tal 2: ");

                if (input == "1" || input == "+" || input == "Plus")
                {
                    resultat = tal1 + tal2;
                }

                if (input == "2" || input == "-" || input == "Træk fra")
                {
                    resultat = tal1 - tal2;
                }

                if (input == "3" || input == "*" || input == "Gange")
                {
                    resultat = tal1 * tal2;
                }

                if (input == "4" || input == "/" || input == "Dividere")
                {
                    resultat = tal1 / tal2;
                }

                Console.WriteLine("---------------------");
                Console.Write("Resultat: ");
                Console.WriteLine(resultat);
                Console.WriteLine("---------------------");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Fra Disimaltal til Binærtal");
                Console.WriteLine("2. Fra Disimaltal til Hex");
                Console.WriteLine("3. Fra Hex til Binærtal");
                Console.WriteLine("4. Fra Hex til Disimaltal");
                Console.WriteLine("5. Fra Binærtal til Hex");
                Console.WriteLine("6. Fra Binærtal til Disimaltal");
                Console.WriteLine("---------------------");
                Console.Write("Vælg funktion: ");
                input = Console.ReadLine();

            }
        }
    }
}
