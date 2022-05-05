using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Final_Capstone_try
{
    public partial class login : Form
    {
        public static MySqlConnection con = null; //create object to open and close connection
        public string server = @"server=cookout.cqow78y7vcx8.us-east-2.rds.amazonaws.com;database=cookout_data;userid=admin;password=1241273Aws";
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(server);
            con.Open();

            string Username = username_textbox.Text;
            string Password = password_textbox.Text;

            //create and find password matching username
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT Password FROM cookout_data.logininfo WHERE Username = '" + Username + "'";
            string checkPassword = (string)command.ExecuteScalar();
            
            //check password in database against one in textbox
            if (Password == checkPassword)
            {
                this.Hide();
                cookout_editor form = new cookout_editor();
                form.ShowDialog();
                this.Close(); //close window
                con.Close(); //close connection
                con.Dispose(); //dispose connection
            }

            //error box for invalid credentials
            else
            {
                string message = "Password or Login was incorrect";
                string title = "Login";
                MessageBox.Show(message, title);
                con.Close();
                con.Dispose();
            }
        }
    }
}
