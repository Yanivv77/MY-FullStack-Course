using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkList = new LinkedList();
            linkList.AddNewItem("cola", 10);
            linkList.AddNewItem("pepsi", 8);
            linkList.AddNewItem("bisli", 6);
            linkList.AddNewItem("bamba", 6);


            //linkList.head.DisplayPrev();
            //linkList.head.DisplayItem();
            //linkList.head.next.DisplayItem();
            //linkList.head.next.next.DisplayItem();
            //linkList.head.next.next.DisplayNext();


            linkList.PrintList();
            linkList.RemoveByName("pepsi");
            linkList.RemoveLast();
            linkList.AddNewItem("Tapozina", 7);
            linkList.PrintList();




            Console.ReadLine();

        }


       








    }
}
