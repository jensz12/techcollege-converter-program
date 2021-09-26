using System;

namespace converter
{
    class Program
    {
        static int readNumber()

        {
            String[] input = new string[10];
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string temp = Console.ReadLine();
                number[i] = Convert.ToInt32(temp);
            }
        }
        static void Main(string[] args)
        {
          
          foreach (int tal in number)
          {
              Console.WriteLine(tal);
          }

        }
    }
}
