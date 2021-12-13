using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Node
    {
        public String data;
        public Node next;
        public Node prev;

        public Node(string data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }


        public void DisplayNode()
        {
            Console.WriteLine(data + " ");

        }


    }
}
