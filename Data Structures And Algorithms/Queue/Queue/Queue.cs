using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Queue
    {
        Item head;
        Item tail;

        public Queue()
        {
            head = null;
            tail = null;
        }

        public void Push(Item newItem)
        {
            if(head == null && tail == null) // empty queue
            {
                head = newItem;
                tail = newItem;
            }
            else //queue not empty
            {
                newItem.next = head;
                head = newItem;

            }

            
        }

        public void pop()
        {
            
            Item current = head;

            while (current.next != tail)
            {

                current = current.next;
            }

            current.next = null;
            tail= current;

        }



        public void PrintQueue()
        {
            System.Console.WriteLine();
            Item currentItem = head;

            while (currentItem != null)
            {
                System.Console.Write(currentItem.ToString() + " ----> ");
                currentItem = currentItem.next;
            }
        }

        



    }
}
