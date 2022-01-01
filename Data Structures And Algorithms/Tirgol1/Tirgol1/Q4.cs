using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol1
{
    internal class Q4
    {
        internal static void LuckMatrix()
        {
            int[] array = new int[10];
            Random rand = new Random();
            int number;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = rand.Next(1, 11);
                }
                while (array.Contains(number));

                array[i] = number;

            }
            Console.WriteLine(String.Join(" ", array));
        }



        internal static int[] StartArray()
        {

            int[] array = new int[10];

            Random rand = new Random();
            int number;



            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = rand.Next(1, 1100);
                }
                while (array.Contains(number));
                array[i] = number;

            }

            return array;

        }


    }
}
