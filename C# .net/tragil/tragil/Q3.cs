using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tragil
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
            Random rnd = new Random();

            for (int i = 0; i < array.Count(); i++)
            {
                int rndNumber = rnd.Next();
                array[i] = rndNumber;

            }

            int counter = 0;

            foreach (int n in array)
            {
                if (n == num)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {

            }

            else if (counter == 1)
            {

            }

            else
            { 
            
            }
                




        }






        }
}
