using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item cola = new Item("cola", 10);
            Item pepsi = new Item("pepsi", 10);
            Item bisli = new Item("bisli", 8);

          Queue que = new Queue();

            que.Push(cola);
            que.Push(pepsi);
            que.Push(bisli);
            que.pop();
            que.PrintQueue();



            Console.ReadLine();

        }
    }
}
