using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        private int id;
        private string first_name;
        private string last_name;
        private DateTime Birthday;



        public Person(int id, string first_name, string last_name, DateTime birthday)
        {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
            Birthday1 = birthday;
        }

        public int Id 
        { get => id; set => id = value; }
        public string First_name 
        { get => first_name; set => first_name = value; }
        public string Last_name 
        { get => last_name; set => last_name = value; }
        public DateTime Birthday1 
        { get => Birthday; set => Birthday = value; }



        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Id == person.Id &&
                   First_name == person.First_name &&
                   Last_name == person.Last_name &&
                   Birthday1 == person.Birthday1;
        }



        public override string ToString()
        {
            return base.ToString();
        }
    }
}
