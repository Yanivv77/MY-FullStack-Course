using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Csharp_And_MySQL
{
    public partial class Cars_Form : Form
    {
        public Cars_Form()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='Cars_db';username=root;password=admin");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }




        public void LoadCarsToGrid()
        {
            // populate the datagridview
            string selectQuery = " SELECT c.Id ,t.type_name , c.Model, c.Description, c.SubDescription, c.Price FROM cars c inner join types t ON c.type_name = t.type_name";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_Cars.DataSource = table;
        }

        private void dataGridView_Cars_SelectionChanged(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridView_Cars.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView_Cars.CurrentRow.Cells[1].Value.ToString();
            textBoxModel.Text = dataGridView_Cars.CurrentRow.Cells[2].Value.ToString();
            textBoxDescription.Text = dataGridView_Cars.CurrentRow.Cells[3].Value.ToString();
            textBoxSubDescription.Text = dataGridView_Cars.CurrentRow.Cells[4].Value.ToString();
            textBoxPrice.Text = dataGridView_Cars.CurrentRow.Cells[5].Value.ToString();

        }



        private void BTN_INSERT_Click(object sender, EventArgs e)
        {

            string Insert = $"call insert_procedure( '{textBoxName.Text}' , '{textBoxDescription.Text}', '{textBoxSubDescription.Text}', '{textBoxModel.Text}', '{textBoxPrice.Text}' )";
            executeMyQuery(Insert);
            LoadCarsToGrid();

            

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {

            string deleteQuery = $"DELETE FROM `cars_db`.`cars` WHERE Id='{textBoxId.Text}'";
            executeMyQuery(deleteQuery);
            LoadCarsToGrid();


        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = $"UPDATE `cars_db`.`cars` SET `type_name` = '{textBoxName.Text}', `Description` = '{textBoxDescription.Text}' , `SubDescription` = '{textBoxSubDescription.Text}', `Model` = '{textBoxModel.Text}', `Price` = {textBoxPrice.Text}  WHERE `Id` = '{textBoxId.Text}' ";
            executeMyQuery(updateQuery);
            LoadCarsToGrid();
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            string select = "SELECT c.Id ,t.type_name , c.Model, c.Description, c.SubDescription, c.Price FROM cars c inner join types t ON c.type_name = t.type_name WHERE id = " + textBoxId.Text;
            command = new MySqlCommand(select, connection);
            openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBoxId.Text = mdr.GetString("Id");
                textBoxName.Text = mdr.GetString("type_name");
                textBoxModel.Text = mdr.GetString("Model");
                textBoxDescription.Text = mdr.GetString("Description");
                textBoxSubDescription.Text = mdr.GetString("SubDescription");
                textBoxPrice.Text = mdr.GetString("Price");

            }
            else
            {
                MessageBox.Show("User Not Found");
            }

            closeConnection();
        }
    }



}






