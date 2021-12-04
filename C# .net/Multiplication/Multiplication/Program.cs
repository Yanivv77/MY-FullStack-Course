using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    internal class Program
    {


        public static void MultiplicationBoard()
        {
            int size = 10;
            string str = "";



            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    str += " # ";
                    String multi = (i * j).ToString();
                    str += multi;

                    if (multi.Length == 1)
                    {
                        str += " ";
                    }



                }
                str += "\n";
            }



            Console.WriteLine(str);
        }


        public static void Prime()
        {


            List<int> list = new List<int>();
            int counter = 0;

            list.Add(2);
            for (int i = 2; i < 100; i++)
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

                    counter++;

                }

            }

            Console.WriteLine(counter);



            foreach (int num in list)
            {
                Console.WriteLine(num);


            }


        }


        public static void Prime2()
        {
           

            List<int> primes = new List<int>(new int[] { 2, 3 });
            for (int n = 5; primes.Count < 25; n += 2)
            {
                bool isPrime = true;
                foreach (int prime in primes.ToList())
                {
                   
                    if (n % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primes.Add(n);
            }


            Console.WriteLine(count);
            foreach (var item in primes)
            {
                Console.WriteLine(item);

            }


        }



        public static void diamond()
        {
            int n = 10 ;
            for (int i = 1; i <= n; i++) // n
            {
               
                for (int j = 1; j <= (n - i); j++) // n-1
                {
                    Console.Write(" ");
                }
                


                for (int k = 1; k < i * 2; k++) // 2n
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = n - 1; i >= 1; i--)
            {

                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    


            public static void tragil14()
            {
             int size = 10;

            for (int i = 1; i < size; i++) //10
            {
                for (int j = 1; j < (size - i); j++) //size-1
                {
                    Console.Write(" ");
                }


                for (int k = 1; k < i*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();




            }


            }



        public static void tragil15()
        {
            int size = 10;

            for (int i = size; i >= 0; i--) //5
            {
                for (int j = i; j < size; j++) //size-1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

        public static void fibo(int size)
        {
            int n = size;
            List<int> list = new List<int>();  
            list.Add(0);   
            list.Add(1);

            for (int i = 0; i < n + 1; i++)
            {
                int sum = list[i] + list[i + 1];
                list.Add(sum);
            }


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        public static void fibo(int size)
        {

        }








        static void Main(string[] args)
            {


            // MultiplicationBoard();
            // Console.WriteLine("\n");

            // Prime2();

            //  diamond();
            //tragil15();
            fibo(10);




            //tragil14();
            Console.ReadKey();




        }
        }
    } 

