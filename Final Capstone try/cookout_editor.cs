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
        //state connection string
        public static MySqlConnection connection = new MySqlConnection(@"server=cookout.cqow78y7vcx8.us-east-2.rds.amazonaws.com;database=cookout_data;userid=admin;password=1241273Aws");
        
        //create command object
        MySqlCommand command;

        //select all querry string
        public static string selectAll = "Select EIN, FirstName, LastName, SundayIN, SundayOUT, MondayIN, MondayOUT, TuesdayIN, TuesdayOUT, WednesdayIN, WednesdayOUT, ThursdayIN, ThursdayOUT, FridayIN, FridayOUT, SaturdayIN, SaturdayOUT FROM employee ORDER BY LastName, FirstName";
        
        //create datatable
        public DataTable dtcookout = new DataTable(); //create datatable to pass to database and allow search function
        
        public int index;
        public cookout_editor()
        {
            InitializeComponent();
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
            theme_combobox.Items.Add("Dark");
            theme_combobox.Items.Add("Light");
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
            //Call refresh
            dbRefresh();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = search_textBox.Text;
            int index = 0;

            for(int i = 0; i < dtcookout.Rows.Count; i++)
            {
                if (dtcookout.Rows[i]["FirstName"].ToString() == search)
                {
                    index = i;
                }
            }
            cookout_datagridview.ClearSelection();
            cookout_datagridview.Rows[index].Selected = true;
        }

        private void theme_button_Click(object sender, EventArgs e)
        {
            string theme = theme_combobox.Text.ToString();

            if(theme == "Dark")
            {
                this.BackColor = Color.FromArgb(70, 70, 70);
                in_label.ForeColor = Color.White;
                out_label.ForeColor = Color.White;

                sunday_label.ForeColor = Color.White;
                sundayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                sundayin_textbox.ForeColor = Color.White;
                sundayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                sundayout_textbox.ForeColor = Color.White;

                monday_label.ForeColor = Color.White;
                mondayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                mondayin_textbox.ForeColor = Color.White;
                mondayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                mondayout_textbox.ForeColor = Color.White;

                tuesday_label.ForeColor = Color.White;
                tuesdayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                tuesdayin_textbox.ForeColor = Color.White;
                tuesdayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                tuesdayout_textbox.ForeColor = Color.White;

                wednesday_label.ForeColor = Color.White;
                wednesdayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                wednesdayin_textbox.ForeColor = Color.White;
                wednesdayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                wednesdayout_textbox.ForeColor = Color.White;

                thursday_label.ForeColor = Color.White;
                thursdayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                thursdayin_textbox.ForeColor = Color.White;
                thursdayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                thursdayout_textbox.ForeColor = Color.White;

                friday_label.ForeColor = Color.White;
                fridayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                fridayin_textbox.ForeColor = Color.White;
                fridayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                fridayout_textbox.ForeColor = Color.White;

                saturday_label.ForeColor = Color.White;
                saturdayin_textbox.BackColor = Color.FromArgb(163, 163, 163);
                saturdayin_textbox.ForeColor = Color.White;
                saturdayout_textbox.BackColor = Color.FromArgb(163, 163, 163);
                saturdayout_textbox.ForeColor = Color.White;

                search_label.ForeColor = Color.White;
                search_textBox.BackColor = Color.FromArgb(163, 163, 163);
                search_textBox.ForeColor = Color.White;

                ein_label.ForeColor = Color.White;
                EIN_textbox.BackColor = Color.FromArgb(163, 163, 163);
                EIN_textbox.ForeColor = Color.White;

                firstname_label.ForeColor = Color.White;
                firstname_textbox.BackColor = Color.FromArgb(163, 163, 163);
                firstname_textbox.ForeColor = Color.White;

                lastname_label.ForeColor = Color.White;
                lastname_textbox.BackColor = Color.FromArgb(163, 163, 163);
                lastname_textbox.ForeColor = Color.White;

                cookout_datagridview.ForeColor = Color.White;
                cookout_datagridview.DefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200);
                cookout_datagridview.GridColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(220, 222, 224);
                in_label.ForeColor = Color.Black;
                out_label.ForeColor = Color.Black;

                sunday_label.ForeColor = Color.Black;
                sundayin_textbox.BackColor = Color.White;
                sundayin_textbox.ForeColor = Color.Black;
                sundayout_textbox.BackColor = Color.White;
                sundayout_textbox.ForeColor = Color.Black;

                monday_label.ForeColor = Color.Black;
                mondayin_textbox.BackColor = Color.White;
                mondayin_textbox.ForeColor = Color.Black;
                mondayout_textbox.BackColor = Color.White;
                mondayout_textbox.ForeColor = Color.Black;

                tuesday_label.ForeColor = Color.Black;
                tuesdayin_textbox.BackColor = Color.White;
                tuesdayin_textbox.ForeColor = Color.Black;
                tuesdayout_textbox.BackColor = Color.White;
                tuesdayout_textbox.ForeColor = Color.Black;

                wednesday_label.ForeColor = Color.Black;
                wednesdayin_textbox.BackColor = Color.White;
                wednesdayin_textbox.ForeColor = Color.Black;
                wednesdayout_textbox.BackColor = Color.White;
                wednesdayout_textbox.ForeColor = Color.Black;

                thursday_label.ForeColor = Color.Black;
                thursdayin_textbox.BackColor = Color.White;
                thursdayin_textbox.ForeColor = Color.Black;
                thursdayout_textbox.BackColor = Color.White;
                thursdayout_textbox.ForeColor = Color.Black;

                friday_label.ForeColor = Color.Black;
                fridayin_textbox.BackColor = Color.White;
                fridayin_textbox.ForeColor = Color.Black;
                fridayout_textbox.BackColor = Color.White;
                fridayout_textbox.ForeColor = Color.Black;

                saturday_label.ForeColor = Color.Black;
                saturdayin_textbox.BackColor = Color.White;
                saturdayin_textbox.ForeColor = Color.Black;
                saturdayout_textbox.BackColor = Color.White;
                saturdayout_textbox.ForeColor = Color.Black;

                search_label.ForeColor = Color.Black;
                search_textBox.BackColor = Color.White;
                search_textBox.ForeColor = Color.Black;

                ein_label.ForeColor = Color.Black;
                EIN_textbox.BackColor = Color.White;
                EIN_textbox.ForeColor = Color.Black;

                firstname_label.ForeColor = Color.Black;
                firstname_textbox.BackColor = Color.White;
                firstname_textbox.ForeColor = Color.Black;

                lastname_label.ForeColor = Color.Black;
                lastname_textbox.BackColor = Color.White;
                lastname_textbox.ForeColor = Color.Black;

                cookout_datagridview.ForeColor = Color.Black;
                cookout_datagridview.DefaultCellStyle.BackColor = Color.White;
                cookout_datagridview.GridColor = Color.Black;
            }
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            index = cookout_datagridview.CurrentRow.Index;
            cookout_datagridview.Rows[index].Selected = false;
            index--;
            cookout_datagridview.Rows[index++].Selected = true;
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            index = cookout_datagridview.CurrentRow.Index;
            cookout_datagridview.Rows[index].Selected = false;
            index++;
            cookout_datagridview.Rows[index++].Selected = true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            //create new form
            var frmEditEmployee = new edit_employee();

            //pass all text box information to edit form text boxes (can be done with class but no time and easier)
            DataRow dtrow = dtcookout.Rows[cookout_datagridview.CurrentRow.Index];
            frmEditEmployee.firstnameedit_textbox.Text = dtrow["FirstName"].ToString();
            frmEditEmployee.lastnameedit_textbox.Text = dtrow["LastName"].ToString();
            frmEditEmployee.EINedit_textbox.Text = dtrow["EIN"].ToString();
            frmEditEmployee.sundayINedit_textbox.Text = dtrow["SundayIN"].ToString();
            frmEditEmployee.sundayOUTedit_textbox.Text = dtrow["SundayOUT"].ToString();
            frmEditEmployee.mondayINedit_textbox.Text = dtrow["MondayIN"].ToString();
            frmEditEmployee.mondayOUTedit_textbox.Text = dtrow["MondayOUT"].ToString();
            frmEditEmployee.tuesdayINedit_textbox.Text = dtrow["TuesdayIN"].ToString();
            frmEditEmployee.tuesdayOUTedit_textbox.Text = dtrow["TuesdayOUT"].ToString();
            frmEditEmployee.wednesdayedit_textbox.Text = dtrow["WednesdayIN"].ToString();
            frmEditEmployee.wednesdayOUTedit_textbox.Text = dtrow["WednesdayOUT"].ToString();
            frmEditEmployee.thursdayINedit_textbox.Text = dtrow["ThursdayIN"].ToString();
            frmEditEmployee.thursdayOUTedit_textbox.Text = dtrow["ThursdayOUT"].ToString();
            frmEditEmployee.fridayINedit_textbox.Text = dtrow["FridayIN"].ToString();
            frmEditEmployee.fridayOUTedit_textbox.Text = dtrow["FridayOUT"].ToString();
            frmEditEmployee.satudayINedit_textbox.Text = dtrow["SaturdayIN"].ToString();
            frmEditEmployee.saturdayOUTedit_textbox.Text = dtrow["SaturdayOUT"].ToString();

            //show form
            frmEditEmployee.Show();
            dbRefresh();
        }

        public void dbRefresh()
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

        private void newEmployee_button_Click(object sender, EventArgs e)
        {
            cookout_datagridview.Rows[0].Selected = true;
            cookout_datagridview.Rows[0].Selected = false;
        }
    }
}
