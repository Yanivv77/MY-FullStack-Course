using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_flights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var dataTable = GetData();
            dataGrid_passengers.DataSource = dataTable;
        }

        private DataTable GetData()
        {
            // or use a connection string
            var MongoClientConnection = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");

            var database = MongoClientConnection.GetDatabase("flights");

            var passengersCollection = database.GetCollection<BsonDocument>("passengers");

            var documents = passengersCollection.Find(new BsonDocument());
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("age");

            foreach (var doc in documents.ToListAsync().Result)
            {

                DataRow dr = table.NewRow();
                dr["name"] = doc[1].ToString();
                dr["age"] = doc[2].ToString();
                table.Rows.Add(dr);
            }
            table.AcceptChanges();

            return table;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(txt_age.Text);
                string name = txt_name.Text;

                Console.WriteLine("Welcome to my first Mongodb example");

                // or use a connection string
                var MongoClientConnection = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");

                var database = MongoClientConnection.GetDatabase("flights");

                var passengersCollection = database.GetCollection<BsonDocument>("passengers");
                var document = new BsonDocument
                                    {
                                        { "name", name },
                                        { "age",age}
                                   };

                passengersCollection.InsertOne(document);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
