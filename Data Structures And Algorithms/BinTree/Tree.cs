using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    internal class Tree
    {
        Hashtable allItems =  new Hashtable();
        const int MaxItems = 7;

        public void initTree()
        {
            for (int i = 0; i < MaxItems; i++)
            {
                Node newNode = new Node(i);
                allItems.Add(newNode.data, newNode);
            }

        }
    }
}
