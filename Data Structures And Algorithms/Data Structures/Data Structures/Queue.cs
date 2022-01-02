using System;

namespace Data_Structures
{
    internal class Queue
    {

        Node front;
        Node end;


        public Queue()
        {
            front = null;
            end = null;
           
        }

        public void Push(Node newNode)
        {
            if (end == null && front == null) // Add First
            {
                front = newNode;
                end = newNode;
                

            }

            else //add to head
            {

                newNode.next = end;
                end = newNode;
                

            }
        }




        public Node pop()
        {

            Node current = end;

            while (current.next.next != null)
            {

                current = current.next;
            }

            Console.WriteLine();
            Console.WriteLine(current.next.ToString() + " Node Deleted " ); 
            
            Node deleted = current.next;

            current.next = null;
            return deleted;

        }

        public void ViewQueue()
        {

            

            Node currentItem = end;

            while (currentItem != null)
            {
                currentItem.DisplayNode();
                currentItem = currentItem.next;

            }
           

        }
        }
}