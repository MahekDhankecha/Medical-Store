using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahi\source\repos\Medical Store\Medical Store\MedicalDB.mdf");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            this.Hide();
            Obj.Show();
        }
        public static string User;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter username and password to login");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void btnadmin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (username == "admin" && password == "adminpass")
            {
                MessageBox.Show("Admin login successful!");

            }
            else
            {
                MessageBox.Show("Invalid admin username or password.");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

        

