using ShopProject.Enums;

namespace ShopProject.Classes.Products.Electronics
{
    internal class ElectronicProduct : Product
    {

        ElectronicCompanies _ElectronicCompanie { get; set; }

        public ElectronicProduct(string name, int price, ElectronicCompanies electronicCompanie) : base(name, price)
        {
            _ElectronicCompanie = electronicCompanie;
        }



        public override string ToString()
        {
            return base.ToString()+$" |Brand : {_ElectronicCompanie} ";
        }
    }



}
