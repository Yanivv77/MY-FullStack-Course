using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace SchoolFile
{
    internal class FilesManager
    {

        public Hashtable SchoolData = new Hashtable();



        public void LoadFormFile()
        {

            string FileName = Directory.GetCurrentDirectory() + @"\SCHOOLS1.csv";
            //System.Console.WriteLine(FileName);

            string[] AllLines = File.ReadAllLines(FileName);
            //Console.WriteLine(String.Join(" ", AllLines));


            for (int i = 0; i < AllLines.Length; i++)
            {
                string line = AllLines[i];
                string[] dataline = line.Split(',');
                Data data = new Data();
                data.year = Int32.Parse(dataline[0]);
                data.SchoolsNum = Int32.Parse(dataline[1]);
                SchoolData.Add(data.year, data);
            }


        }

 
        public void DisplayData()
        {

            foreach (object data in SchoolData.Keys)
            {
                Data Sdata = (Data)SchoolData[data];
                Sdata.DisplayData();

            }
        }

        internal void CheckSchools()
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());


            if (!SchoolData.ContainsKey(num))
            {
                Console.WriteLine("Year dont exist in data ");
                return;
            }
            else
            {
                Data data = (Data)SchoolData[num];
                Console.WriteLine(data.SchoolsNum);
            }    
            
        }


        internal void Check5AvgBack()
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            if (!SchoolData.ContainsKey(num-5))
            {
                Console.WriteLine("Year dont exist in data ");
                return;
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {

                    
                    Data data = (Data)SchoolData[num - i];
                    sum = sum + data.SchoolsNum;
                    


                }
                Console.WriteLine(sum/5);
            }

        }



    }


}



