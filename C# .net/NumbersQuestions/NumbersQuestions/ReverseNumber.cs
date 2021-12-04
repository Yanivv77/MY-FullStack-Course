using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class ReverseNumber
    {
        public static void ReverseNumbers(int num)
        {
            int num1  = num;
            int num2 = 0;

            while (num != 0)
            {
                int rem = num % 10;
                num /= 10;
                num2 = num2 * 10 + rem;
            }

            Console.WriteLine(num2);

        }


    }
}
