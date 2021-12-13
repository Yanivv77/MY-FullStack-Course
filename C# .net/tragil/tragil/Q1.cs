using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tragil
{
    internal class Q1
    {

        public static void random ()
        {
            int num  = Int32.Parse(Console.ReadLine());

            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 9);

            if(num == rndNumber)
            {
                Console.WriteLine("bull");
            }
            else if (num == rndNumber+1   || num ==rndNumber-1)
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("miss");
            }



        }

            








    }
}
