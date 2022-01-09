using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_And_MongoDB
{
    internal class Course
    {

        public object CourseName { get; set; }

        public override string ToString()
        {
            return CourseName.ToString();
        }

    }
}
