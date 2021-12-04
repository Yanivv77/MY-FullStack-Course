using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class CountDigits
    {
        public static void CountDigitsNumber(int num)
        {
            int count = 0;
            while(num != 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
