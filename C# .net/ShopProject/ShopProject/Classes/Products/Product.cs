using ShopProject.Exceptions;

namespace ShopProject.Classes.Products
{
    abstract internal class Product
    {

        public static int Count = 0;

        protected int SerialNumber;
        protected string _ProductName;
        protected int _Price;

        public string ProductName
        {
            get { return ProductName; }

            set
            {
                string msg = "The name must be over 3 letters";

                if (value.Length >=3)
                    _ProductName = value;
                else
                    throw new IllegalArgument(msg);
            }
        }


        protected int Price
        {

            get { return _Price; }

            set
            {
                string msg = "Price must be over 0";
                if (value > 0)
                    _Price = value;
                else
                    throw new IllegalArgument(msg);
            }
        }



        protected Product(string name, int price)
        {
            Count++;
            SerialNumber = Count;
            _ProductName = name;
            _Price = price;


        }

        public override string ToString()
        {
            return "[" + GetType().Name + $" |Name: {_ProductName}|Serial Number:{SerialNumber} |Price: {_Price}";
        }


    }



}
