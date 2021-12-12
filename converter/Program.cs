using System;

namespace Ider_til_opg
{
    class Program
    {
        static void Binærtal_til_Hex()
        {
            string[] binærtal = new string[8];
            int[] hextal1 = new int[4];
            int[] hextal2 = new int[4];
            for (int i = 0; i < 8; i++)
            {
                binærtal[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i2 = 0; i2 < 4; i2++)
            {
                string[] hex1 = new string[4];
                hex1[i2] = binærtal[i2];
                hextal1[i2] = Convert.ToInt32(hex1[i2]);
            }
            int i4 = 0;
            for (int i3 = 4; i3 < 8; i3++)
            {
                string[] hex2 = new string[i3];
                hex2[i4] = binærtal[i3];
                hextal2[i4] = Convert.ToInt32(hex2[i4]);
                i4++;
            }
            int x = 1;
            for (int a = 0; a < 4; a++)
            {
                hextal1[a] = hextal1[a] * x;
                x = x * 2;
            }
            x = 1;
            for (int a = 0; a < 4; a++)
            {
                hextal2[a] = hextal2[a] * x;
                x = x * 2;
            }
            string[] bogstaver = { "A", "B", "C", "D", "E", "f" };
            int hexdi1 = hextal1[0] + hextal1[1] + hextal1[2] + hextal1[3];
            int hexdi2 = hextal2[0] + hextal2[1] + hextal2[2] + hextal2[3];
            if (hexdi1 > 9)
            {
                if (hexdi1 == 10)
                    Console.Write(bogstaver[0]);

                if (hexdi1 == 11)
                    Console.Write(bogstaver[1]);

                if (hexdi1 == 12)
                    Console.Write(bogstaver[2]);

                if (hexdi1 == 13)
                    Console.Write(bogstaver[3]);

                if (hexdi1 == 14)
                    Console.Write(bogstaver[4]);

                if (hexdi1 == 15)
                    Console.Write(bogstaver[5]);
            }

            if (hexdi2 > 9)
            {
                if (hexdi2 == 10)
                    Console.Write(bogstaver[0]);

                if (hexdi2 == 11)
                    Console.Write(bogstaver[1]);

                if (hexdi2 == 12)
                    Console.Write(bogstaver[2]);

                if (hexdi2 == 13)
                    Console.Write(bogstaver[3]);

                if (hexdi2 == 14)
                    Console.Write(bogstaver[4]);

                if (hexdi2 == 15)
                    Console.Write(bogstaver[5]);
            }
            Console.ReadKey();
        }
        static void Decimaltal_til_Binærtal()
        {
            int x = 128;
            string Decimal = Console.ReadLine();
            int Decimaltal = Convert.ToInt32(Decimal);
            for (int a = 0; a != 8; a++)
            {
                if (Decimaltal > x || Decimaltal == x)
                {
                    Console.Write(1);
                    Decimaltal = Decimaltal - x;
                    x = x / 2;

                }
                else
                {
                    Console.Write(0);
                    x = x / 2;
                }
            }
            Console.ReadKey();
        }
        static void Decimaltal_til_Hex()
        {
            int x = 128;
            string[] binærtal = new string[8];
            int[] hextal1 = new int[4];
            int[] hextal2 = new int[4];
            string Decimal = Console.ReadLine();
            int Decimaltal = Convert.ToInt32(Decimal);
            Console.Clear();
            for (int a = 0; a != 8; a++)
            {
                if (Decimaltal > x || Decimaltal == x)
                {
                    binærtal[a] = "1";
                    Decimaltal = Decimaltal - x;
                    x = x / 2;

                }
                else
                {
                    binærtal[a] = "0";
                    x = x / 2;
                }
            }

            for (int i2 = 0; i2 < 4; i2++)
            {
                string[] hex1 = new string[4];
                hex1[i2] = binærtal[i2];
                hextal1[i2] = Convert.ToInt32(hex1[i2]);
            }
            int i4 = 0;
            for (int i3 = 4; i3 < 8; i3++)
            {
                string[] hex2 = new string[i3];
                hex2[i4] = binærtal[i3];
                hextal2[i4] = Convert.ToInt32(hex2[i4]);
                i4++;
            }
            x = 1;
            for (int a = 0; a < 4; a++)
            {
                hextal1[a] = hextal1[a] * x;
                x = x * 2;
            }
            x = 1;
            for (int a = 0; a < 4; a++)
            {
                hextal2[a] = hextal2[a] * x;
                x = x * 2;
            }
            string[] bogstaver = { "A", "B", "C", "D", "E", "f" };
            int hexdi1 = hextal1[0] + hextal1[1] + hextal1[2] + hextal1[3];
            int hexdi2 = hextal2[0] + hextal2[1] + hextal2[2] + hextal2[3];
            if (hexdi1 > 9)
            {
                if (hexdi1 == 10)
                    Console.Write(bogstaver[0]);

                if (hexdi1 == 11)
                    Console.Write(bogstaver[1]);

                if (hexdi1 == 12)
                    Console.Write(bogstaver[2]);

                if (hexdi1 == 13)
                    Console.Write(bogstaver[3]);

                if (hexdi1 == 14)
                    Console.Write(bogstaver[4]);

                if (hexdi1 == 15)
                    Console.Write(bogstaver[5]);
            }

            if (hexdi2 > 9)
            {
                if (hexdi2 == 10)
                    Console.Write(bogstaver[0]);

                if (hexdi2 == 11)
                    Console.Write(bogstaver[1]);

                if (hexdi2 == 12)
                    Console.Write(bogstaver[2]);

                if (hexdi2 == 13)
                    Console.Write(bogstaver[3]);

                if (hexdi2 == 14)
                    Console.Write(bogstaver[4]);

                if (hexdi2 == 15)
                    Console.Write(bogstaver[5]);
            }
            Console.ReadKey();
        }
        static void Binærtal_til_Decimaltal()
        {
            int x = 128;

            string[] binærtal = new string[8];
            int[] tal = new int[8];
            for (int i = 0; i < 8; i++)
            {
                binærtal[i] = Console.ReadLine();

            }
            Console.Clear();
            for (int a = 0; a < 8; a++)
            {
                tal[a] = Convert.ToInt32(binærtal[a]);
            }
            for (int b = 0; b < 8; b++)
            {
                tal[b] = tal[b] * x;
                x = x / 2;
            }
            int ialt = tal[0] + tal[1] + tal[2] + tal[3] + tal[4] + tal[5] + tal[6] + tal[7];
            Console.WriteLine(ialt);
            Console.ReadKey();
        }
        static Double ReadDouble(string tekst)
        {
            Console.Write(tekst);
            // Den får et input som den laver om til en double så retuner den doublen
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
                Console.WriteLine("1. Fra Decimaltal til Binærtal");
                Console.WriteLine("2. Fra Decimaltal til Hex");
                Console.WriteLine("3. Fra Hex til Binærtal");
                Console.WriteLine("4. Fra Hex til Decimaltal");
                Console.WriteLine("5. Fra Binærtal til Hex");
                Console.WriteLine("6. Fra Binærtal til Decimaltal");
                Console.WriteLine("---------------------");
                Console.Write("Vælg funktion: ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Fra Decimaltal til Binærtal");
                    Console.WriteLine("Skriv et Decimaltal fra 0 til 255");
                    Console.WriteLine("---------------------");
                    Decimaltal_til_Binærtal();
                }
                if (input == "2")
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Fra Decimaltal til Hex");
                    Console.WriteLine("Skriv et Decimaltal fra 0 til 255");
                    Console.WriteLine("---------------------");
                    Decimaltal_til_Hex();
                }
                if (input == "5")
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Fra Binærtal til Hex ");
                    Console.WriteLine("Skriv et binærtal fra 0 til 1, 8 gange  ");
                    Console.WriteLine("---------------------");
                    Binærtal_til_Hex();
                }
                if (input == "6")
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Fra Binærtal til Decimaltal ");
                    Console.WriteLine("Skriv et binærtal fra 0 til 1, 8 gange  ");
                    Console.WriteLine("---------------------");
                    Binærtal_til_Decimaltal();
                }
            }
        }
    }
}
