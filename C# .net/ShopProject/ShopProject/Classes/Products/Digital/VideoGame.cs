using ShopProject.Enums;
using ShopProject.Interfaces;

namespace ShopProject.Classes.Products.Digital
{
    internal class VideoGame : DigitalProduct, IDigital


    {

        GameCompanies _GameCompanie { get; set; }
        Genre _Genre { get; set; }
        bool _SinglePalyerOnly { get; set; }




        public VideoGame(string name, int price, double size, GameCompanies gameCompanie, Genre genre, bool singlePalyerOnly) : base(name, price, size)
        {
            _GameCompanie = gameCompanie;
            _Genre = genre;
            _SinglePalyerOnly = singlePalyerOnly;
        }



        public bool Multiplayerable() => _SinglePalyerOnly = false;

        public override string ToString()
        {
            return base.ToString() + $"|GameCompanie : {_GameCompanie} |Genre : {_Genre} |SinglePalyerOnly : {_SinglePalyerOnly}]";
        }




    }
}
