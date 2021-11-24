using ShopProject.Enums;
using ShopProject.Exceptions;

namespace ShopProject.Classes.Products.Electronics
{
    internal class Phone : ElectronicProduct
    {
        double _PhoneScreenSize;


        public Phone(string name, int price, ElectronicCompanies electronicCompanie, double phoneScreenSize) : base(name, price, electronicCompanie)
        {
            PhoneScreenSize = phoneScreenSize;
        }

        double PhoneScreenSize
        {
            get { return _PhoneScreenSize; }
            set
            {

                string msg = "Phone screen size must be over 5 inch and under 10 inch";

                if (value >= 5 && value <10)
                    _PhoneScreenSize = value;
                else
                    throw new IllegalArgument(msg);

            }
        }

        public override string ToString()
        {
            return base.ToString()+$"|Screen Size: {_PhoneScreenSize} Inch] ";
        }
    }
}
