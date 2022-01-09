using MongoDB.Bson;
using System;

namespace Csharp_And_MongoDB
{
    internal class Student
    {

        public ObjectId _id { get ; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public object Courses { get; set; }

    }
}