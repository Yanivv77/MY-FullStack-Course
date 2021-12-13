using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pais
{
    internal class LotoManager
    {
        public Hashtable Cards = new Hashtable();
        public int MaxNum;

        public void LoadFormFile()
        {
            string FileName = System.IO.Directory.GetCurrentDirectory() + @"loto.csv";

            string[] allLies = System.IO.File.ReadAllLines(FileName);
            for (int i = 0; i < allLies.Length; i++)
            {
                string[] oneRecord = allLies[i].Split(',');
                Card newCard = new Card();
                newCard.Id = Convert.ToInt32(oneRecord[0]);
                newCard.StrongNum = Byte.Parse(oneRecord[8]);
                for (int j = 0; j < oneRecord.Length; j++)
                {
                    newCard.Numbers[j] = byte.Parse(oneRecord[j + 1]);
                }

                Cards.Add(newCard.Id, newCard);

            }





        }

        public int GetMaxNumber()
        {
            byte max = 0;
            var allKeys = Cards.Keys;

            foreach (var item in allKeys)
            {
                Card currCard = (Card)Cards[item];
                if (currCard.Numbers[currCard.Numbers.Length - 1] > max)
                {
                    max = currCard.Numbers[currCard.Numbers.Length - 1];
                }
            }

            return max;

        }
    }
}
