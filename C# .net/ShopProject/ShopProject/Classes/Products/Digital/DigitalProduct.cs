using ShopProject.Exceptions;

namespace ShopProject.Classes.Products.Digital
{
    internal class DigitalProduct : Product
    {

        protected double _Size;




         double Size
        {
            get { return _Size; }
            set
            {

                string msg = "Size must be over 0 GB and under 99 GB";

                if (value > 0 && value <99)
                    _Size = value;
                else
                    throw new IllegalArgument(msg);

            }
        }

        public DigitalProduct(string name, int price, double size) : base(name, price)
        {
            Size = size;

        }

        public override string ToString()
        {
            return base.ToString() + $" |Size : {_Size} ";
        }
    }
}
