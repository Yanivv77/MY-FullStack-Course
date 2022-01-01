using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Item
    {
        public string _name;
        public int _price;
        public Item next;

        public Item(string name, int price)
        {
            _name = name;
            _price = price;
            next = null;
        }

        public override string ToString()
        {
            return _name + " " + _price;
        }
    }
}
