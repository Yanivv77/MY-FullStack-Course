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

        public int year;
        public int marryMen;
        public int marryWomen;
        public int DivMen;
        public int DivWomen;


        public void DisplayData()
        {
            Console.WriteLine($"Year {year} Marryed Men {marryMen} Marryed Women {marryWomen} Divorced Women {DivMen} divorced Women {DivWomen}");
        }


    }
}
