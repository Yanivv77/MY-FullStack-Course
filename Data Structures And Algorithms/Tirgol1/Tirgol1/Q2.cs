using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol1
{
    internal class Q2
    {

        public static void RandomArray()
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Number Is Invalid");
                return;
            }

            int[] array = new int[num];
            Random rand = new Random();

            for (int i = 0; i < array.Count(); i++)
            {
            
   
                array[i] = rand.Next(1, 9);
            }

            Console.WriteLine(String.Join(" ", array));


        }




    }
}
