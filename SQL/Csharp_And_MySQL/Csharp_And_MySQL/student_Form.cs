using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Csharp_And_MySQL
{
    public partial class student_Form : Form
    {
        public student_Form()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3307;Database=PromoIt;Uid=root;Pwd=rootp");
        MySqlCommand command;

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        private void Cars_Form_Load(object sender, EventArgs e)
        {
           // LoadCarsToGrid();

        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            
            finally
            {
                closeConnection();
            }
        }




        public void LoadCarsToGrid()
        {
            // populate the datagridview
            string selectQuery = " call selectAll_procedure(); ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_Cars.DataSource = table;
        }

        private void dataGridView_Cars_SelectionChanged(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridView_Cars.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView_Cars.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView_Cars.CurrentRow.Cells[2].Value.ToString();
            textBoxAge.Text = dataGridView_Cars.CurrentRow.Cells[3].Value.ToString();

        }



        private void BTN_INSERT_Click(object sender, EventArgs e)
        {

            AddBusiness("dfsdf", "dfsdf", "Business", "dfsdf");



            //string Insert = $"call insert_procedure( '{textBoxFirstName.Text}' ,  '{textBoxLastName.Text}', '{textBoxAge.Text}' )";
            //executeMyQuery(Insert);
            //LoadCarsToGrid();

            

        }

        public void AddBusiness(string username, string passwrod, string usertype
            , string name)
        {

            string AddBusiness = $"call AddBusiness_procedure ('{username}' ,'{passwrod}' , '{usertype}' ,'{name}');";
            executeMyQuery(AddBusiness);

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {

            string deleteQuery = $"call delete_procedure ('{textBoxId.Text}');'";
            executeMyQuery(deleteQuery);
            LoadCarsToGrid();


        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = $"call update_procedure ('{textBoxId.Text}' ,'{textBoxFirstName.Text}' , '{textBoxLastName.Text}' ,'{textBoxAge.Text}' );";
            executeMyQuery(updateQuery);
            LoadCarsToGrid();
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            string select = $"call selectById_procedure('{textBoxId.Text}')";
            command = new MySqlCommand(select, connection);
            openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBoxId.Text = mdr.GetString("Id");
                textBoxFirstName.Text = mdr.GetString("firstName");
                textBoxLastName.Text = mdr.GetString("lastName");
                textBoxAge.Text = mdr.GetString("age");

            }
            else
            {
                MessageBox.Show("User Not Found");
            }

            closeConnection();
        }

        
    }



}






