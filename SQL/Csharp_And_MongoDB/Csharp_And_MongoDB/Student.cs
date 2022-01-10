using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace Csharp_And_MongoDB
{
    internal class Student
    {

        public ObjectId _id { get ; set; }
        public int id_num { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
        public string Course { get; set; }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            LastName = lastName;

            Courses =new List<Course> { new Course(" ") };
        }
    }
}