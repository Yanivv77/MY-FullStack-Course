using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    internal class Node
    {


        public int data { get; set; }
        Node ChildRight { get; set; }
        Node ChildLeft { get; set; }

        public Node(int Data)
        {
            data = Data;
            ChildRight = null;
            ChildLeft = null;

        }

        public override string ToString()
        {
            return data + " ";
        }


        public void ViewNode()
        {
            Console.Write(data + " ");
        }


    }



}

