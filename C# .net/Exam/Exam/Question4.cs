using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question4
    {

        public static string GetNextNumber(string input, int End = 0)
        {
            if (End >= input.Length)
            {
                return "".PadLeft(input.Length, '0');
            }

            
            int digit = int.Parse(input[input.Length - 1 - End].ToString());


            if (digit == 9) 
            {
                return GetNextNumber(input, ++End);
            }
            else
            {
                return input.Substring(0, input.Length - 1 - End) + (++digit).ToString().PadRight(End + 1, '0');
            }
        }




    }
}
