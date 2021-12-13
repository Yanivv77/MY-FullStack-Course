using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tragil
{
    internal class Q2
    {

        public static void randomArray()
        {
            int num = Int32.Parse(Console.ReadLine());
            int[] array = new int[num];
            Random rnd = new Random();

            for (int i = 0; i < array.Count(); i++)
            {
                int rndNumber = rnd.Next();
                array[i] = rndNumber;

            }

            Console.WriteLine(String.Join(" ", array));

        }
    }
}
