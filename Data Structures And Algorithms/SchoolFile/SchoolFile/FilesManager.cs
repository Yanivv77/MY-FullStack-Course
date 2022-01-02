using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFile

    internal class FilesManager
    {

        public static void ReadFile()
        {

        var reader = new StreamReader(\test.csv"))
        
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
            }
        }





    }




    }
}
