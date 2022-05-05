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
    public partial class newEmployee : Form
    {
        //state connection string
        public static MySqlConnection connection = new MySqlConnection(@"server=cookout.cqow78y7vcx8.us-east-2.rds.amazonaws.com;database=cookout_data;userid=admin;password=1241273Aws");

        //create command object
        MySqlCommand command;
        public string color;
        public newEmployee(string theme)
        {
            InitializeComponent();

            //decide theme
            color = theme;
        }

        private void addNew_button_Click(object sender, EventArgs e)
        {
            //create strings to grab textbox information
            string firstName, lastName, EIN;
            EIN = EINnew_textbox.Text;
            firstName = firstnamenew_textbox.Text;
            lastName = lastnamenew_textbox.Text;
            
            //create new command text
            string insert = "INSERT INTO `cookout_data`.`employee` (`EIN`, `FirstName`, `LastName`) VALUES('" + EIN + "', '" + firstName + "', '" + lastName + "')";

            //open connection
            connection.Open();

            //check connection
            if(connection.State == ConnectionState.Open)
            {
                //execute insert command and tell user the result
                command = new MySqlCommand("", connection);
                command.CommandText = insert;
                command.ExecuteNonQuery();

                MessageBox.Show("Employee was added. Please edit times accordingly.");
                connection.Close();
                connection.Dispose();
                command.Dispose();
            }
            //could not connect to database
            else
            {
                connection.Close();
                connection.Dispose();
                MessageBox.Show("Error: Unable to establish Connection");
            }

        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newEmployee_Load(object sender, EventArgs e)
        {
            //select theme on loading
            if(color == "Dark")
            {
                EINnew_textbox.BackColor = Color.FromArgb(163, 163, 163);
                EINnew_textbox.ForeColor = Color.White;
                ein_label.ForeColor = Color.White;

                firstnamenew_textbox.BackColor = Color.FromArgb(163, 163, 163);
                firstnamenew_textbox.ForeColor = Color.White;
                firstname_label.ForeColor = Color.White;

                lastnamenew_textbox.BackColor = Color.FromArgb(163, 163, 163);
                lastnamenew_textbox.ForeColor = Color.White;
                lastname_label.ForeColor = Color.White;

                this.BackColor = Color.FromArgb(41, 42, 43);
            }

            else
            {
                EINnew_textbox.BackColor = Color.White;
                EINnew_textbox.ForeColor = Color.Black;
                ein_label.ForeColor = Color.Black;

                firstnamenew_textbox.BackColor = Color.White;
                firstnamenew_textbox.ForeColor = Color.Black;
                firstname_label.ForeColor = Color.Black;

                lastnamenew_textbox.BackColor = Color.White;
                lastnamenew_textbox.ForeColor = Color.Black;
                lastname_label.ForeColor = Color.Black;

                this.BackColor = Color.FromArgb(220, 222, 224);
            }
        }
    }
}
