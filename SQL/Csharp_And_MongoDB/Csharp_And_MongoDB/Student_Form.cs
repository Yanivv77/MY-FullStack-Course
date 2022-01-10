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
        MongoClient client;
        IMongoDatabase database;
        IMongoCollection<Student> collection;
        IMongoCollection<BsonDocument> collection2;
        BindingList<Student> doclist;

        public Student_Form()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");
            database = client.GetDatabase("TsionetSchool");
            collection = database.GetCollection<Student>("Students");
            collection2 = database.GetCollection<BsonDocument>("Students");
            LoadStudentToGrid();
        }

        public void LoadStudentToGrid()
        {

            doclist = new BindingList<Student>();
            var Studentslist = collection.Find(_ => true).ToList();
            int id = 1;



            foreach (var student in Studentslist)
            {

                string coursesString = " | ";
                foreach (Course course in student.Courses)
                {
                    coursesString += course.CourseName + " | ";
                }
                student.Course = coursesString;
                student.id_num = id;
                id += 1;

                doclist.Add(student);

            }

            dataGridView_Student.DataSource = doclist;
            dataGridView_Student.Columns["_id"].Visible = false;
            dataGridView_Student.Columns["id_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_Student.Columns["id_num"].HeaderText = "ID";
            dataGridView_Student.Columns["firstName"].HeaderText = "First Name";
            dataGridView_Student.Columns["LastName"].HeaderText = "Last Name";
            dataGridView_Student.Columns["Course"].HeaderText = "Courses";
        }


        private void dataGridView_Student_SelectionChanged(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridView_Student.CurrentRow.Cells[1].Value.ToString();
            textBoxFristName.Text = dataGridView_Student.CurrentRow.Cells[2].Value.ToString();
            textBoxLastName.Text = dataGridView_Student.CurrentRow.Cells[3].Value.ToString();
            //textBoxCourse.Text = dataGridView_Student.CurrentRow.Cells[4].Value.ToString();

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {

            foreach (var student in doclist)
            {
                if (student.id_num == Int32.Parse(textBoxId.Text))
                {
                    ObjectId id = ObjectId.Parse(student._id.ToString());
                    var filter = Builders<Student>.Filter.Eq("_id", id);
                    var update = Builders<Student>.Update.Set("firstName", textBoxFristName.Text);
                    var update2 = Builders<Student>.Update.Set("LastName", textBoxLastName.Text);
                    collection.UpdateOne(filter, update);
                    collection.UpdateOne(filter, update2);
                    LoadStudentToGrid();
                    break;
                }
            }
        }

        private void BTN_InsertCourse_Click(object sender, EventArgs e)
        {

            foreach (var student in doclist)
            {
                if (student.id_num == Int32.Parse(textBoxId.Text))
                {
                    ObjectId id = ObjectId.Parse(student._id.ToString());

                    var filter = Builders<Student>.Filter.Eq("_id", id);


                    var update = Builders<Student>.Update.Push("Courses", new Course(textBoxCourse.Text) ); 
               
                    collection.UpdateOne(filter, update);
                  
                    textBoxCourse.Text = " ";
                    LoadStudentToGrid();
                    break;
                }
            }



        }



        private void BTN_INSERT_Click(object sender, EventArgs e)
        {


            var document = new BsonDocument
                {

                { "firstName", textBoxFristName.Text },
                { "LastName", textBoxLastName.Text },
                { "Courses",  new BsonArray {  } }
                };


                collection2.InsertOne(document);
                LoadStudentToGrid();


        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {


            foreach (var student in doclist)
            {
                if (student.id_num == Int32.Parse(textBoxId.Text))
                {
                    ObjectId id = ObjectId.Parse(student._id.ToString());

                    var filter = Builders<Student>.Filter.Eq("_id", id);



                    collection.DeleteOne(filter);
                    LoadStudentToGrid();
                    
                   
                    break;
                }
            }




        }
    }
    

}










