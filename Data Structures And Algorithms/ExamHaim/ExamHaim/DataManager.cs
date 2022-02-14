using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHaim
{
    internal class DataManager
    {

        public Hashtable MarryData = new Hashtable();

        public void LoadFormFile()
        {

            string FileName = Directory.GetCurrentDirectory() + @"\HALMAS.csv";
            //System.Console.WriteLine(FileName);

            string[] AllLines = File.ReadAllLines(FileName);
            //Console.WriteLine(String.Join(" ", AllLines));


            for (int i = 0; i < AllLines.Length; i++)
            {

                string line = AllLines[i];
                string[] dataline = line.Split(',');
                Data data = new Data();
                data.year = Int32.Parse(dataline[0]);
                data.marryMen = Int32.Parse(dataline[1]);
                data.marryWomen = Int32.Parse(dataline[2]);
                data.DivMen = Int32.Parse(dataline[3]);
                data.DivWomen = Int32.Parse(dataline[4]);
                MarryData.Add(data.year, data);


            }


        }

        public void DisplayData()
        {

            foreach (object data in MarryData.Keys)
            {
                Data Sdata = (Data)MarryData[data];
                Sdata.DisplayData();

            }
        }





        public void QueryData()
        {

            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Data data = (Data)MarryData[num];


            if (!MarryData.ContainsKey(num))
            {
                Console.WriteLine("Year dont exist in data ");
                
            }
            else
            {
                

                // 5.a
                int TotalMarry = data.marryMen + data.marryWomen;
                Console.WriteLine("Total Marry in "+ num + " : "  + TotalMarry);

                // 5.b
                if (data.marryMen > data.marryWomen)
                {
                    Console.WriteLine("More marryed Men in " + num + " : " + data.marryMen);
                }
                else
                {
                    Console.WriteLine("More marryed Women in "+ num +" : " + data.marryWomen);
                }

                // 5.c
                int TotalDivorce = data.DivMen + data.DivWomen;
                Console.WriteLine("Total Divorce in " + num + " : " + TotalDivorce);

              
                if (!MarryData.ContainsKey(num-1))
                {
                    Console.WriteLine("Year dont exist in data ");
                    return;
                }
                else
                {


                    // 5.d
                    Data dataMinusOne = (Data)MarryData[num-1];
                    int TotalMarryed = data.marryMen + data.marryWomen;
                    int TotalMarryMinusOne = dataMinusOne.marryMen + dataMinusOne.marryWomen;
                    if (TotalMarryMinusOne > TotalMarryed)
                    {
                        Console.WriteLine("More marrayed last year " + (num - 1)+ " last year more marryes : " + + (TotalMarryMinusOne - TotalMarryed));
                        
                    }
                    else
                    {
                        Console.WriteLine("More marrayed this year^");
                    }




                    // 5.e
                    Data dataPlusOne = (Data)MarryData[num + 1];
                    int TotalDivorcePlusOne = dataPlusOne.DivMen + dataPlusOne.DivWomen;
                    if ( TotalDivorce > TotalDivorcePlusOne )
                    {
                        Console.WriteLine("More marrayed this year " + (num) + " this year more divorces : " + (TotalDivorce - TotalDivorcePlusOne));
                        
                    }
                    else
                    {
                        Console.WriteLine("More divorce next year");
                    }


                    

                    

                }

            

            }

            //5.f
            Console.Write("Years with even marrayes ");
            var allKeys = MarryData.Keys;
            foreach (var item in allKeys)
            {
                Data currYear = (Data)MarryData[item];
                if ((currYear.marryMen + currYear.marryWomen) % 2 == 0)
                {
                    Console.Write(" " + currYear.year + " ");
                }
            }

        }



    }
}
