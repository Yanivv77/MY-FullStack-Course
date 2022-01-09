using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSortTree
{
    internal class Node
    {
        
        public int data;
        public int levelNode;
        public Node rightChildNode;
        public Node leftChildNode;

    

    public Node(int Data)
    {
        data = Data;
        levelNode = 0;
        rightChildNode = null;
        leftChildNode = null;


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




