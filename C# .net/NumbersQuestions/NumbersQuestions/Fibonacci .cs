using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class Fibonacci
    {


        public static void FibonacciSequence(int n)
        {

            if (n < 0)
            {
                Console.WriteLine(n + "Should be non negative");
                return;
            }

            List<int> febo = new List<int>(new int[] { 0, 1 });

            for (int i = 2; i < n; i++)
            {
                int num1 = febo.ElementAt(i - 1);
                int num2 = febo.ElementAt(i - 2);
                febo.Add(num1 + num2);
            }

            febo.ForEach(Console.WriteLine);
        }



        public static void GetNthFibonacci(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0  
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            Console.WriteLine(Fib[number]);
        }




        public static int FibonacciSumRecursion(int n)
        {
            if (n < 0)
            { 
                Console.WriteLine(n + "Should be non negative");
                return 0;
            }
            

            else if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            else
                return (FibonacciSumRecursion(n - 1) + FibonacciSumRecursion(n - 2));
        }





    }
}
