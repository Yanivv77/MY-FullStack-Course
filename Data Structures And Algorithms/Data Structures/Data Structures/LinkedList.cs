using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class LinkedList
    {
        Node head { get; set; }
        Node tail { get; set; }

        int size { get; set; }
        

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void AddFirst(Node NewNode)
        {
            if (head == null && tail == null) // Add First
            {
                head = NewNode;
                tail = NewNode;
                size++;
               
            }

            else //add to head
            {

                NewNode.next = head;
                head.prev = NewNode;
                head = NewNode;
                size++;
               
            }

        }


        public void AddLast(Node NewNode) 
        {
            if (head == null && tail == null ) // Add First
            {
                head = NewNode;
                tail = NewNode;
                size++;
                return;
            }

            else //add last 
            {
            
                NewNode.prev = tail;
                tail.next = NewNode;
                tail = NewNode;
                tail.next = null;
                size++;
                return;
            }

        }

        public void AddAtIndex(Node NewNode, int Index)
        {

            if (Index > 0 && Index < size)
            {
                Node current = head;
                for (int i = 1; i < Index - 1; i++)
                {
                    current = current.next;
                }

                current.next.prev = NewNode;
                NewNode.prev = current;
                NewNode.next = current.next;
                current.next = NewNode;
                size++;

            }

            else
            {
                Console.WriteLine("Error index not exist");
            }
        }


        public void RemoveFirst()
        {

            if (head == tail)
            {
                head = null;
                tail = null;
                size--;
                return;
            }

            else if(head != null && tail != null) // Not Empty
            {
                head = head.next;
                head.prev = null;
                size--;
                return;
            }
            else
            {
                Console.WriteLine("Erorr");
            }
        }


        public void RemoveLast()
        {

            if (head == tail)
            {
                head = null;
                tail = null;
                size--;
                return;
            }

            else if (head != null && tail != null) // Not Empty
            {
                Node current = head;
                while (current.next != tail)
                {
                    current = current.next;
                }
                current.next = null;
                tail = current;
                size--;
                return;
            }
            else
            {
                Console.WriteLine("Erorr");
            }
        }


        public void RemoveAt(int Index )
        {
            if (Index == 1)
            {
                RemoveFirst();
            }

            else if (Index == size)
            {
                RemoveLast();
            }
            else if (Index > 0 && Index < size)
            {
                Node current = head;
                for (int i = 1; i < Index ; i++)
                {
                    current = current.next;
                }

                current.prev.next = current.next;
                current.next.prev = current.prev;
                size--;
                return;
            }

            else
            {
                Console.WriteLine("Error index not exist");
            }

        }

        public void ViewList()
        {
          



            Console.Write("|Head| ");
            Node current = head;
            while (current != null)
            {
                current.DisplayNode();
                current = current.next;
            }
            Console.Write("|Tail| ");
            Console.WriteLine("");
            
        }



    }
}
