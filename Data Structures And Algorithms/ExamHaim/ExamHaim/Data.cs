using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHaim
{
    internal class Data
    {
        //תקופה  	נישאים-חתנים	נישאים-כלות  	מתגרשים-בעלים	מתגרשים-נשים

        public int year { get; set; }
        public int marryMen { get; set; }
        public int marryWomen { get; set; }
        public int DivMen { get; set; }
        public int DivWomen { get; set; }


        public void DisplayData()
        {
            Console.WriteLine($"Year {year} Marryed Men {marryMen} Marryed Women {marryWomen} Divorced Women {DivMen} divorced Women {DivWomen}");
        }


    }
}
