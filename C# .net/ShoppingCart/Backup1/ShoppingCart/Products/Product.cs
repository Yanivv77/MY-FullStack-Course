namespace ShoppingCart.Products
{
    abstract class Product
    {
        protected int ProductID { get; set; } = 0;
        protected string Name { get; set; }

        public Product(int productID,string name)
        {
            ProductID = productID;
            Name = name;
        }

        public override string ToString()
        {
            return "ID "+ ProductID + "Name " + Name;
        }
    }
}
