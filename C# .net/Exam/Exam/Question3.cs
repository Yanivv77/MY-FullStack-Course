using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question3
    {

        public static void primeFactors(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
            { 
                Console.Write(n);
            }
            Console.WriteLine();
        }

      

        public static string primeFactorss(int n)
        {
            string str = "";

            while (n % 2 == 0)
            {
                str += "2 ";
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {

                while (n % i == 0)
                {
                    str += i.ToString()+" ";
                    n /= i;
                }
            }
            if (n > 2)
            {
                str += n.ToString();
            }

            return str;
        }




       












    }
}
