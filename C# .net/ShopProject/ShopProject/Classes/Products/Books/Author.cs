using ShopProject.Enums;
using ShopProject.Exceptions;
using System.Linq;

namespace ShopProject.Classes.Products.Books
{
    internal class Author
    {
        string _Id;
        string _FName;
        string _LName;
        double _Age;
        Gender _Gender { get; set; }

        public string Id
        {
            get { return _Id; }
            set
            {
                string msg = "ID length must be 9 ";
                string msg2 = "ID should be numbers only";

                if (!value.All(char.IsDigit))
                {

                    throw new IllegalArgument(msg2);
                }
                if (value.Length != 9)
                {
                    throw new IllegalArgument(msg);
                }
                else
                    _Id = value;


            }
        }

        string FName
        {
            get { return _FName; }
            set
            {
                string msg = "The first name must be over 2 letters";

                if (value.Length >=2)
                    _FName = value;
                else
                    throw new IllegalArgument(msg);
            }
        }

        string LName
        {
            get { return _LName; }
            set
            {
                string msg = "The last name must be over 2 letters";

                if (value.Length >=2)
                    _LName = value;
                else
                    throw new IllegalArgument(msg);
            }
        }

        double Age
        {
            get { return _Age; }
            set
            {
                string msg = "Illegal age input";

                if (value >= 8 && value <120)
                    _Age = value;
                else
                    throw new IllegalAge(msg);
            }
        }



        public Author(string id, string fName, string lName, double age, Gender gender)
        {
            Id=id;
            FName=fName;
            LName=lName;
            Age=age;
            _Gender=gender;
        }

        public override string ToString()
        {
            return $"(Id: {_Id}|Name: {_FName} {_LName}|Age: {_Age}|Gender: {_Gender}) ";
        }
    }


}
