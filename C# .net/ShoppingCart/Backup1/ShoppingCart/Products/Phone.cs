using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Products
{
    class Phone : Product
    {
        string CompanyName { get; set; }
        Double ScreenSize { get; set; }

        public Phone(string companyName, double screenSize) 
        {
            CompanyName = companyName;
            ScreenSize = screenSize;
        }

        public override string ToString()
        {
            return base.ToString()+ CompanyName + " "+ ScreenSize;
        }
    }
}
