using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Item
    {
        public string _name { get; set; }
        public int _price { get; set; }
        public Item next { get; set; }

        public Item prev {  get; set; }


        public Item(string name, int price)
        {
            _name = name;
            _price = price;
            next=null;
            prev=null;
        }


        public void DisplayItem()
        {
           
                Console.WriteLine("[" + _name + " | " + _price + "]");
        }

        public void DisplayPrev()
        {
            if (prev == null)
            {
                Console.WriteLine("null");
                
            }
            else
            {
                prev.DisplayItem();
            }

        }

        public void DisplayNext()
        {
            if (next == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                next.DisplayItem();
                
            }    
        }

        public override string ToString()
        {
            return  "["+ _name + "|" + _price+"]";
        }
    }
}
