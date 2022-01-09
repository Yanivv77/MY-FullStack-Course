using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace Csharp_And_MongoDB
{
    public partial class Student_Form : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<BsonDocument> m_collection;

        public Student_Form()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");
            m_Database = m_Client.GetDatabase("TsionetSchool");
            m_collection = m_Database.GetCollection<BsonDocument>("Students");

        }



        private void Student_Form_Load(object sender, EventArgs e)
        {
            LoadStudentToGrid();

        }



        public void LoadStudentToGrid()
        {

        }

        
    }


}










