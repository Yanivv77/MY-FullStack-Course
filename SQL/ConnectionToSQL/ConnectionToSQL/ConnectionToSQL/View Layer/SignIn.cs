using ConnectionToSQL.DA_Layer;
using ConnectionToSQL.Helper;
using ConnectionToSQL.PD_Layer;
using ConnectionToSQL.View_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionToSQL
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Users aUser = UsersDA.RetrieveUser(username);
            if(aUser.Password.Equals(password))
            {
                MessageBox.Show("Login Success");
                View_Layer.MainMenu m = new View_Layer.MainMenu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Login Failed. Please try again");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
