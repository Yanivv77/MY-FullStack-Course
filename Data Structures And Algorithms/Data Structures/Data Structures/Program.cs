using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList linklistA = new LinkedList();
            LinkedList linklistB = new LinkedList();
            LinkedList linklistC = new LinkedList();

            Node a = new Node("1 cola");
            Node b = new Node("2 bamba");
            Node c = new Node("3 bisli");
            Node d = new Node("4 fanta");
            Node x = new Node("X crambo");



            Console.WriteLine("--- LinkedList ---");
            // add first
            linklistA.AddFirst(a);
            linklistA.AddFirst(b);
            linklistA.AddFirst(c);
            linklistA.AddFirst(d);
            linklistA.ViewList();

            linklistA.RemoveFirst();
            linklistA.ViewList();
            Console.WriteLine();


            // add last
            linklistB.AddLast(a);
            linklistB.AddLast(b);
            linklistB.AddLast(c);
            linklistB.AddLast(d);
            linklistB.ViewList();

            linklistB.RemoveLast();
            linklistB.ViewList();
            Console.WriteLine();



            linklistC.AddLast(a);
            linklistC.AddLast(b);
            linklistC.AddLast(c);
            linklistC.AddLast(d);
            linklistC.AddAtIndex(x, 3);
            linklistC.ViewList(); //[1 cola] [2 bamba] [X crambo] [3 bisli] [4 fanta] |Tail|

            linklistC.RemoveAt(3);
            linklistC.ViewList();//[1 cola] [2 bamba] [3 bisli] [4 fanta] |Tail|

            linklistC.RemoveAt(4);
            linklistC.ViewList(); //|Head| [1 cola] [2 bamba] [3 bisli] |Tail|

            linklistC.RemoveAt(1);
            linklistC.ViewList(); //|Head| [2 bamba] [3 bisli] |Tail|
            Console.WriteLine();




            Console.WriteLine("--- Queue ----");
            Queue que = new Queue(); // FIFO

            que.Push(new Node("1 cola"));
            que.Push(new Node("2 bamba"));
            que.Push(new Node("3 bisli"));
            que.Push(new Node("4 fanta"));
            que.ViewQueue();
            Console.WriteLine();

           
            que.pop();
            que.ViewQueue();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" --- Stack  ----");
            Stack stack = new Stack(); // LIFO

            stack.Push(new Node("1 cola"));
            stack.Push(new Node("2 bamba"));
            stack.Push(new Node("3 bisli"));
            stack.Push(new Node("4 fanta"));
            stack.ViewStack();
            //Console.WriteLine();

            Console.WriteLine();
            stack.pop();
            stack.ViewStack();









            Console.ReadLine();






        }
    }
}
