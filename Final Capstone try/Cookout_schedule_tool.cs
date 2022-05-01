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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection(@"server=cookout.cqow78y7vcx8.us-east-2.rds.amazonaws.com;user id=admin;password=1241273Aws;persistsecurityinfo=True;database=cookout_data;allowuservariables=True");
        MySqlCommand command;
        MySqlDataReader reader;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookout_dataDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.cookout_dataDataSet.employee);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string message = "Are you sure you want to save changes?";
            string title = "Save/Update";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                employeeBindingSource.EndEdit();
                employeeTableAdapter.Update(cookout_dataDataSet);
                MessageBox.Show("Data was successfully saved", "Save/Update", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Save was canceled", title, MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void connection_button_Click(object sender, EventArgs e)
        {
            conn.Open();

            string state = conn.State.ToString();
            string title = "connection state";
            MessageBox.Show(state, title);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string search = "SELECT * FROM cookout_dataDataSet.employee WHERE FirstName=" + int.Parse(search_textBox.Text.ToString());
            command = new MySqlCommand(search);

            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString("FirstName");
                int rowIndex = employeeDataTable.Rows.Equals(name).Inde

                employeeDataTable.Rows[].Selected = true;
            }
        }
    }
}
