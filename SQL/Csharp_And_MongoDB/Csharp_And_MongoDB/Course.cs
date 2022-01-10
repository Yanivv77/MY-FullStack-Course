using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_And_MongoDB
{
    internal class Course
    {

        public string CourseName { get; set; }



        public Course(string str)
        {
            CourseName = str;
        }


        public override string ToString()
        {
            return CourseName;
        }

    }
}
