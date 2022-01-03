using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFile
{
    internal class Data
    {
       public int year { get; set; }
       public int SchoolsNum { get; set; }

        public void DisplayData()
        {
            Console.WriteLine($"Year {year} Schools {SchoolsNum}");
        }
    }
}
