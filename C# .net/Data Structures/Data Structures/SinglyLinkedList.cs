using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class SinglyLinkedList
    {
        Node head;
        Node tail;
        int size;


        public SinglyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;

        }

        public void AddFirst(Node newData)
        {

            if (head == null)
            {
                head = newData;
                return;
            }


            else
            {

                Node current = head;

                while (current.next != null)
                {

                    current = current.next;

                }

                current.prev = current;
                current.next = newData;


            }

        }





    }



    }
