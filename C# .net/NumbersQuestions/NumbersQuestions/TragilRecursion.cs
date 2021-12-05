using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class TragilRecursion
    {

        public static string GetNextNumber(string input, int positionFromEnd = 0)
        {
            if (positionFromEnd >= input.Length)
            {
                return "".PadLeft(input.Length, '0');
            }

            int digit = int.Parse(input.Substring(input.Length - 1 - positionFromEnd, 1));
            if (digit == 9)
            {
                return GetNextNumber(input, ++positionFromEnd);
            }
            else
            {
                return input.Substring(0, input.Length - 1 - positionFromEnd) + (++digit).ToString().PadRight(positionFromEnd + 1, '0');
            }

        }
    }
}
