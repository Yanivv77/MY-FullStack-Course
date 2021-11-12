using ShopProject.Exceptions;

namespace ShopProject.Classes.Products.Digital
{
    internal class Audiobook : DigitalProduct
    {
        protected int _AudioTime;

        protected int AudioTime
        {
            get { return _AudioTime; }
            set
            {

                string msg = "Audio time must be over 30 minutes and under 999 minutes";

                if (value > 30 && value <999)
                {
                    _AudioTime = value;
                }
                else
                {
                    throw new IllegalArgument(msg);
                }

            }
        }
        public Audiobook(string name, int price, double size, int audioTime) : base(name, price, size)
        {
            AudioTime = audioTime;
        }

        public override string ToString()
        {
            return base.ToString() +$"|Audio Time : {_AudioTime}]";
        }
    }
}
