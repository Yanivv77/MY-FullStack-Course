using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol1
{
    internal class Q1
    {
        public static void Guess()
        {
            Console.WriteLine("Enter 1-9 Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 9)
            {
                Console.WriteLine("Number Is Invalid");
                
            }

            Random rand = new Random();
            int randomNumber = rand.Next(1, 9);

            if (num == randomNumber)
            {
                Console.WriteLine("bulls eye");
            }
            else if (num == randomNumber + 1 || num == randomNumber - 1)
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("lose");
            }
        }
    }
}
