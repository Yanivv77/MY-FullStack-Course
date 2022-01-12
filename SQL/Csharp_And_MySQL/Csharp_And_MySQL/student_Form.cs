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

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school';username=root;password=admin");
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
            LoadCarsToGrid();

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

            string Insert = $"call insert_procedure( '{textBoxFirstName.Text}' ,  '{textBoxLastName.Text}', '{textBoxAge.Text}' )";
            executeMyQuery(Insert);
            LoadCarsToGrid();

            

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






