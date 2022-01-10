using System;
using System.Collections;

namespace multy
{
    internal class Program
    {


        public static int PowerRecurtion(int x, int y)
        {
            if (y > 0)
            {
                return x * PowerRecurtion(x, (y - 1));

            }
            else if (y < 0)
            {
                return x * PowerRecurtion(x, (y + 1));
            }

            else return 1;

        }




        public static void HashTime(int x)
        {
            DateTime dt1 = DateTime.Now;
            TimeSpan ts1 = new TimeSpan(dt1.Ticks);

            Hashtable th = new Hashtable();

            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                int n = rnd.Next(1, 100);
                th.Add(i,n);
            }


            DateTime dt2 = DateTime.Now;
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);


            Console.WriteLine("hash run time " + (ts2 - ts1));
        }

        public static void QueTime(int x)
        {
            DateTime dt1 = DateTime.Now;
            TimeSpan ts1 = new TimeSpan(dt1.Ticks);

            Queue que = new Queue();

            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                int n = rnd.Next(1, 100);
                que.Enqueue(n);
            }


            DateTime dt2 = DateTime.Now;
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);


            Console.WriteLine("que run time " + (ts2 - ts1));
        }


        public static void StackTime(int x)
        {
            DateTime dt1 = DateTime.Now;
            TimeSpan ts1 = new TimeSpan(dt1.Ticks);

            Stack sta = new Stack();

            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                int n = rnd.Next(1, 100);
                sta.Push(n);
            }


            DateTime dt2 = DateTime.Now;
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);


            Console.WriteLine("stack run time " + (ts2 - ts1));
        }


        static void Main(string[] args)
        {


            HashTime(1000);

            QueTime(1000);

            StackTime(1000);

            Console.ReadLine();
        }
    }
}
