using System;

namespace Tirgol1
{
    internal class Q3
    {
        internal static void RandomArrayGuess()
        {
            Console.WriteLine("Enter 1 to 1100 Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 1100)
            {
                Console.WriteLine("Number Is Invalid");

            }

            int[] array = new int[100];
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                array[i] = rand.Next(1, 1100);
            }

            Console.WriteLine();
            Console.WriteLine(String.Join(" | ", array));
            Console.WriteLine();

            int counter = 0;


            foreach (int n in array)
            {
                if (n == num)
                {
                    counter++;
                }
            }


            if (counter == 1)
            {
                Console.WriteLine("Win");
            }
            else if (counter > 1)
            {
                Console.WriteLine("Multy Win");
            }
            else
            {
                Console.WriteLine("Lose");
            }


        }
    }
}
