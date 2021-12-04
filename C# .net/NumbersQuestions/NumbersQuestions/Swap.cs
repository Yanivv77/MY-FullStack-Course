using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class Swap
    {

        // swap two numbers without using a temp
        public static void SwapTwoNumbers(int num1, int num2)
        {
            Console.WriteLine("First Number : " + num1 + " Second Number : " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("New First Number : " + num1 + " New Second Number : " + num2);
        }
    }

}