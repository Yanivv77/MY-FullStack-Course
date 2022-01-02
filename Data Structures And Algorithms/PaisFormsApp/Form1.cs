using hashTable.Models;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PaisFormsApp
{
    public partial class Form1 : Form
    {
        LotteryManager lm = new LotteryManager();
        bool isClicked = false;

        public Form1()
        {
            InitializeComponent();
            lm.loadFromFile();
            gridview();
            lastResultLbl.Text = getLastResult();
            strongNumLbl.Text = getLasStrongNum();
        }

        public string getLasStrongNum()
        {
            lm.setLotteryArray();
            int SIZE = lm.lotteryArray.Count;
            Lottery l = (Lottery)lm.lotteryArray[0];
     
            return l.storngNumber.ToString();
        }

        public string getLastResult ()
        {
           //get from hash table by key ==> Lottery l = (Lottery) lm.lotteryTable[44];
            lm.setLotteryArray();
            int SIZE = lm.lotteryArray.Count;
            Lottery l = (Lottery)lm.lotteryArray[0];
            
            string s = "|";

            for (int i = 0; i <6; i++)
            {
                s += $" {l.numbers[i]} | ";

            }

            return s;

        }

        private void top6Btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"   Top 6 numbers:\n" +
                            $" =============\n" +
                            $"  {top6Numbers()}\n" +
                            $" =============");

            //frequencyGridView.DataSource = top6NumbersTable();

        }
        private string top6Numbers()
        {
            string topNumbers = "";

            int[] numbers = lm.frequencyOfNumbers();

            int SIZE = 6;
            for (int i = 0; i < SIZE; i++)
            {
                int maxValue = numbers.Max();
                int maxIndex = numbers.ToList().IndexOf(maxValue);
                numbers[maxIndex] = -1;
                topNumbers += $"{maxIndex}, ";
            }
            int lastMaxValue = numbers.Max();
            int lastMaxIndex = numbers.ToList().IndexOf(lastMaxValue);
            topNumbers += lastMaxIndex;

            return topNumbers;
        }

        private DataTable top6NumbersTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Number");
            table.Columns.Add("Frequency");

            int[] numbers = lm.frequencyOfNumbers();

            int SIZE = 6;
            for (int i = 0; i < SIZE; i++)
            {
                int maxValue = numbers.Max();
                int maxIndex = numbers.ToList().IndexOf(maxValue);
                numbers[maxIndex] = -1;

                DataRow dr = table.NewRow();
                dr["Number"] = maxIndex;
                dr["Frequency"] =maxValue;

                table.Rows.Add(dr);

            }

            return table;

        }

        private void getMaxNumber(object sender, EventArgs e)
        {

            MessageBox.Show($"The max number is: {lm.getMaxNum()}");

        }

        public DataTable GetResultGridTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Date");
            table.Columns.Add("Numbers");
            table.Columns.Add("Strong number");

            foreach (object o in lm.lotteryTable.Keys)
            {
                Lottery currentLootery = (Lottery)lm.lotteryTable[o];
                
                DataRow dr = table.NewRow();
                
                dr["ID"] = currentLootery.id;
                dr["Date"] = currentLootery.date;
                dr["Numbers"] = currentLootery.getNumbers();
                dr["Strong number"] = currentLootery.storngNumber;

                table.Rows.Add(dr);
            }
            return table;
        }

        public DataTable GetFrequencyGridTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Number");
            table.Columns.Add("Frequency");

            int[] numbers = lm.frequencyOfNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                DataRow dr = table.NewRow();
                dr["Number"] = i+1;
                dr["Frequency"] = numbers[i];

                table.Rows.Add(dr);

            }
         
            return table;
        }

        public void gridview()
        {
            frequencyGridView.DataSource = GetFrequencyGridTable();
            resultsGridView.DataSource = GetResultGridTable();

        }

        /*        private void readData(object sender, EventArgs e)
                {
                    if (!isClicked)
                    {
                        lm.loadFromFile();
                        gridview();
                        isClicked = true;
                    }

                    else
                    {
                        MessageBox.Show("The data already been initialized");
                    }
                }*/

        private void checkFrequencyOfNumber(object sender, EventArgs e)
        {
            if (numToCheck_txtBox.Text !="")
            {
                byte numToCheck = byte.Parse(numToCheck_txtBox.Text);
                if (numToCheck < 1 | numToCheck > 49)
                {
                    MessageBox.Show("The number should be between 1-49 ");
                    numToCheck_txtBox.Clear();
                }

                else
                {
                    int[] numbers = lm.frequencyOfNumbers();
                    numToCheck_txtBox.Text = numbers[numToCheck - 1].ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frequencyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
