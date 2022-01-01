using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol1
{
    internal class Q6
    {

        public static void BubbleSort()
        {
            int[] array = Q4.StartArray();
            int temp;

            for (int i = 0; i < array.Length-1; i++)
            {

                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }  


            }
            Console.WriteLine(String.Join(" ", array));




        }


    }
}
