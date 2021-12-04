using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersQuestions
{
    internal class PrimeNumber
    {

        public static void CheckPrimeorNot(int n)
        {

            if (n < 1)
            {
                Console.WriteLine(n + " is Not Prime ");
                return;
            }

            if (n == 1 || n == 2)
            {
                Console.WriteLine(n + " is a Prime ");
                return;
            }

            for (int i = 3; i < n / 2; i = i + 2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is Not Prime.");
                    return;

                }


            }

            Console.WriteLine(n + " is a Prime ");
            return;


        }



        public static void PrimeRange(int Range)
        {
            List<int> list = new List<int>();
            list.Add(2);
            for (int i = 2; i < Range; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }

                    if (j == i - 1)
                    {
                        list.Add(j + 1);
                    }
                }

            }
            list.ForEach(Console.WriteLine);

        }


        public static void PrimeCount(int x)
        {
           

            List<int> primes = new List<int>(new int[] { 2, 3 });
            for (int n = 5; primes.Count < x; n += 2)
            {
               
                foreach (int prime in primes)
                {
                    
                    if (n % prime == 0)
                    {
                        break;
                    }

                }
                primes.Add(n);


            }
            primes.ForEach(Console.WriteLine);

            


        }
    }
} 