using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Products
{
    class Book : Product
    {
        String Author {get; set; }
        int PublishedYear {get; set; }

        public Book(string author, int publishedYear)
        {
            Author = author;
            PublishedYear = publishedYear;
        }

        public override string ToString()
        {
            return base.ToString()+ Author + " " + PublishedYear;
        }
    }
}
