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
    public partial class cookout_editor : Form
    {
        public static MySqlConnection connection = new MySqlConnection(@"server=cookout.cqow78y7vcx8.us-east-2.rds.amazonaws.com;database=cookout_data;userid=admin;password=1241273Aws");
        MySqlCommand command;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        public static string selectAll = "Select EIN, FirstName, LastName, SundayIN, SundayOUT, MondayIN, MondayOUT, TuesdayIN, TuesdayOUT, WednesdayIN, WednesdayOUT, ThursdayIN, ThursdayOUT, FridayIN, FridayOUT, SaturdayIN, SaturdayOUT FROM employee";
        public DataTable dtcookout = new DataTable(); //create datatable to pass to database and allow search function

        public cookout_editor()
        {
            InitializeComponent();
        }

        private void connection_check_button_Click(object sender, EventArgs e)
        {
            //check internet connection to database
            connection.Open();
            string state = connection.State.ToString();
            string title = "connection state";
            MessageBox.Show(state, title);
            connection.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            //Open connection and querry database for items
            connection.Open();
            command = new MySqlCommand(selectAll, connection);
            dtcookout.Load(command.ExecuteReader()); //Load database into table through reader

            //close all connections and dispose
            connection.Close();
            command.Dispose();
            connection.Dispose();

            //Create custom settings for datagrid view
            cookout_datagridview.DataSource = dtcookout;
            cookout_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cookout_datagridview.ReadOnly = true;
            cookout_datagridview.RowHeadersVisible = false;
            cookout_datagridview.AllowUserToAddRows = false;
        }

        private void cookout_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //employee information passed to text boxes for editing from clicking on specific cells
            EIN_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["EIN"].ToString();
            firstname_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["FirstName"].ToString();
            lastname_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["LastName"].ToString();
            sundayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["SundayIN"].ToString();
            sundayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["SundayOUT"].ToString();
            mondayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["MondayIN"].ToString();
            mondayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["MondayOUT"].ToString();
            tuesdayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["TuesdayIN"].ToString();
            tuesdayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["TuesdayOUT"].ToString();
            wednesdayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["WednesdayIN"].ToString();
            wednesdayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["WednesdayOUT"].ToString();
            thursdayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["ThursdayIN"].ToString();
            thursdayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["ThursdayOUT"].ToString();
            fridayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["FridayIN"].ToString();
            fridayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["FridayOUT"].ToString();
            saturdayin_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["SaturdayIN"].ToString();
            saturdayout_textbox.Text = dtcookout.Rows[cookout_datagridview.CurrentRow.Index]["SaturdayOUT"].ToString();
        }

        private void cookout_editor_Load(object sender, EventArgs e)
        {
            //Open connection and querry database for items
            connection.Open();
            command = new MySqlCommand(selectAll, connection);
            dtcookout.Load(command.ExecuteReader()); //Load database into table through reader

            //close all connections and dispose
            connection.Close();
            command.Dispose();
            connection.Dispose();

            //Create custom settings for datagrid view
            cookout_datagridview.DataSource = dtcookout;
            cookout_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cookout_datagridview.ReadOnly = true;
            cookout_datagridview.RowHeadersVisible = false;
            cookout_datagridview.AllowUserToAddRows = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = search_textBox.Text;
            int index = 0;

            for(int i = 0; i < dtcookout.Rows.Count; i++)
            {
                /*if (dtcookout.Rows[cookout_datagridview.CurrentCell.ColumnIndex]["FirstName"].Contains(search))
                {
                    index = i;
                }*/
            }

            cookout_datagridview.Rows[index].Selected = true;
        }
    }
}
