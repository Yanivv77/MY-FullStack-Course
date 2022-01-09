using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class SortedTree
    {
        public Node root;

        public void Init()
        {
            // Read from Console new number for first Node
            Node n = new Node();
            n.val = Int32.Parse(Console.ReadLine());

            root = n;

            // Read from Conosole another 10 new Nodes
            for (int i = 0; i < 10; i++)
            {
                n = new Node();
                n.val = Int32.Parse(Console.ReadLine());

                AddNode(root, n);
            }

        }

        public void Print(Node curr)
        {
            /// רקורסיה
        }

        public void AddNode(Node curr,Node newNode)
        {
            if(curr.val < newNode.val)
            {
                // right
                if (curr.right == null)
                {
                    curr.right = newNode;
                }
                else
                {
                    AddNode(curr.right, newNode);
                }
            }
            else
            {
                // left
                if (curr.left == null)
                {
                    curr.left = newNode;
                }
                else
                {
                    AddNode(curr.left, newNode);
                }
            }
        }
    }
 }
