using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol1
{
    internal class Q5
    {

        public static void InsertionSort()
        {
            int[] array = Q4.StartArray();
            Console.WriteLine(String.Join(" ", array));

            int[] sortedArray = new int[10];


            for (int i = 0; i < array.Count(); i++)
            {

                int key = array[i];
                int j = i - 1;

                while (j >= 0 && sortedArray[j] > key)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j = j - 1;
                }

                sortedArray[j + 1] = key;
            }


            Console.WriteLine(String.Join(" ", sortedArray));

        }



    }
}
