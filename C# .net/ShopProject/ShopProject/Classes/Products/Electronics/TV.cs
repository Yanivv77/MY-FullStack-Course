using ShopProject.Enums;
using ShopProject.Exceptions;

namespace ShopProject.Classes.Products.Electronics
{
    internal class TV : ElectronicProduct
    {
        int _TvScreenSize;



        public TV(string name, int price, ElectronicCompanies electronicCompanie, int tvScreenSize) : base(name, price, electronicCompanie)
        {
            TvScreenSize = tvScreenSize;
        }

        int TvScreenSize
        {
            get { return TvScreenSize; }
            set
            {

                string msg = "Tv screen size must be over 30 inch and under 140 inch";

                if (value >= 30 && value <140)
                    _TvScreenSize = value;
                else
                    throw new IllegalArgument(msg);

            }
        }


        public override string ToString()
        {
            return base.ToString()+$"|Screen Size:{_TvScreenSize} Inch ]";
        }


    }
}
