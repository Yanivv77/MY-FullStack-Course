using ShopProject.Classes.Products;
using System.Collections;
using System.Text;

namespace ShopProject.Classes
{
    internal class Shop
    {

        string ShopName { get; set; }
        ArrayList IetmList { get; set; }

        public Shop(string shopName)
        {
            ShopName = shopName;
            IetmList = new ArrayList();

        }


        public void addProduct(Product p)
        {
            if (!IetmList.Contains(p))
                IetmList.Add(p);
            else
                System.Console.WriteLine("item already in store");

        }

        public void removeProduct(Product p)
        {
            if (IetmList.Contains(p))
                IetmList.Remove(p);
            else
                System.Console.WriteLine("item isn't in the store");

        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            foreach (Product p in IetmList)
            {
                str.AppendLine(p.ToString());
                str.AppendLine();
            }

            return str.ToString(); ;
        }
    }







}
