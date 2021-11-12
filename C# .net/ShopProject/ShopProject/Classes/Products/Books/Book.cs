using ShopProject.Enums;
using ShopProject.Exceptions;
using System.Collections;
using System.Text;

namespace ShopProject.Classes.Products.Books
{
    internal class Book : Product
    {
        int _PublishYear;
        int _PagesNum;
        Genre _Genre { get; set; }
        ArrayList _Authors = new ArrayList();

        int PublishYear
        {
            get { return _PublishYear; }

            set
            {
                string msg = "Illegal Publish Year";
                int currentYear = System.DateTime.Now.Year;
                ;
                if (value > 1900 &&  value < currentYear)
                    _PublishYear = value;
                else
                    throw new IllegalArgument(msg);
            }
        }

        int PagesNum
        {
            get { return _PagesNum; }

            set
            {
                string msg = "Illegal number of pages";
                if (value > 0)
                {

                    _PagesNum = value;
                }
                else
                {

                    throw new IllegalArgument(msg);

                }

            }

        }




        public Book(string name, int publishYear, int price, ArrayList authors, int pagesNum, Genre genre) : base(name, price)
        {
            PublishYear =  publishYear;
            PagesNum = pagesNum;
            _Authors = authors;
            _Genre = genre;
        }

        public override string ToString()
        {

            StringBuilder str = new StringBuilder();
            foreach (var author in _Authors)
            {
                str.Append(author.ToString());
            }

            return base.ToString() + $"|Pages Number: {_PagesNum }|Genre: {_Genre }|Publish Year: {_PublishYear }|" +"Authors: " + str+ "]";
        }
    }
}
