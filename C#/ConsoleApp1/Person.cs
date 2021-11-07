using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        int id;
        string name;
        string gender;
       

        public Person(string name, string gender)
        {
            this.name = Name;
            this.gender = Gender;
            
        }


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
   

        public string Gender
        {
        get { return gender; }
        set { this.gender = Gender; }
    }

        public int Id
        {
            get { return this.Id; }
            set { this.Id = Id; }
        }
        

        public override string ToString()
        {
            return "Person: " + name + " " + gender;
        }
    }
}
