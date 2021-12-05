using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class Factorial
    {

        public static void FactorialOfNumber(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;    
            }
            Console.WriteLine(fact);

        }

        public static int FactorialRecursion(int num)
        {
            if (num >= 1)
                return num * FactorialRecursion(num - 1);
            else
                return 1;
        }








    }
}
