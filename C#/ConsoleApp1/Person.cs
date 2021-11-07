using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        string name = "";
        string gender = "";
       

        public Person(string name, string gender)
        {
            this.name = name;
            this.gender = gender;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

    }
}
