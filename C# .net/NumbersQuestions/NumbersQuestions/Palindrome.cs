using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class Palindrome
    {
        public static void CheckPalindrome(int num)
        {
            int n = num;
            int num1 = num;
            int num2 = 0;
            while (num != 0)
            {
                int rem = num % 10;
                num /= 10;
                num2 = num2 * 10 + rem;
            }

            if (num1 == num2)
                Console.WriteLine (n + " It is Palindrome");
            else
                Console.WriteLine (n + " It is not Palindrome");

        }



    }
}
