using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;

using MongoDB.Driver.Linq;
using System.Web.Script.Serialization;

namespace Csharp_And_MongoDB
{
   


    public partial class Student_Form : Form
    {
        


        public Student_Form()
        {
            InitializeComponent();

            MongoClient client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");
            IMongoDatabase database = client.GetDatabase("TsionetSchool");
            IMongoCollection <Student> collection = database.GetCollection<Student>("Students");

            BindingList<Student> doclist = new BindingList<Student>();

            var Studentslist = collection.Find(_ => true).ToList();


            foreach (var student in Studentslist) 
            {

                doclist.Add(student);
               
            }
            dataGridView_Student.DataSource = doclist;
            dataGridView_Student.Columns["_id"].Visible = false;



        }



        private void Student_Form_Load(object sender, EventArgs e)
        {
            







           






        }



        public void LoadStudentToGrid()
        {
            



          





        }

        
    }


}










