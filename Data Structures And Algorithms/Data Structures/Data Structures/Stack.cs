using System;

namespace Data_Structures
{
    internal class Stack
    {
        Node top { get; set; }


        public void Push(Node NewNode)
        {
            if (top == null) // Add First
            {
                top = NewNode;
                return;
            }
            else //add last 
            {
                NewNode.next =top ;
                top = NewNode;

                
                
                return;
            }
        }

        public Node pop()
        {

            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return top;
            }

            else
            {
                Node deleted = top;
                top = top.next;
                Console.WriteLine(deleted.ToString() + " Node Deleted ");
                return deleted;
            }

            

        }


        public void ViewStack()
        {
            
            Node currentItem = top;

            while (currentItem != null)
            {
                currentItem.DisplayNode();
                currentItem = currentItem.next;

            }
            Console.WriteLine();
        }
    }
}
