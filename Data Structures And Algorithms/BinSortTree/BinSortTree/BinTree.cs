using System.Collections.Generic;

namespace BinSortTree
{
    internal class BinTree
    {
        public Node root;
        List<Node> NodeList;

        public void init()
        {

            root = new Node(10);
            NodeList = new List<Node>();
    
            NodeList.Add(new Node(20));
            NodeList.Add(new Node(4));
            NodeList.Add(new Node(7));
            NodeList.Add(new Node(10));
            NodeList.Add(new Node(12));
            NodeList.Add(new Node(26));
            NodeList.Add(new Node(2));
            NodeList.Add(new Node(14));
            NodeList.Add(new Node(5));
            NodeList.Add(new Node(7));

        }


        public void AddNode(Node NewVal)
        {
            if(root.data > NewVal.data)
            {
                root.rightChildNode = NewVal;

            }
            else
            {
                root.leftChildNode = NewVal;
            }

        }



    }

}
