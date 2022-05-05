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
    public partial class edit_employee : Form
    {
        MySqlCommand cmdEmployee = new MySqlCommand("", cnEmployee);
        public static MySqlConnection cnEmployee = new MySqlConnection(@"server=cookout.cqow78y7vcx8.us-east-2.rds.amazonaws.com;database=cookout_data;userid=admin;password=1241273Aws");
        string theme;
        public edit_employee(string temp)
        {
            InitializeComponent();
            theme = temp;
        }

        private void edit_employee_Load(object sender, EventArgs e)
        {
            //select theme on load
            if (theme == "Dark")
            {
                this.BackColor = Color.FromArgb(41, 42, 43);
                in_label.ForeColor = Color.White;
                out_label.ForeColor = Color.White;

                sunday_label.ForeColor = Color.White;
                sundayINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                sundayINedit_textbox.ForeColor = Color.White;
                sundayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                sundayOUTedit_textbox.ForeColor = Color.White;

                monday_label.ForeColor = Color.White;
                mondayINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                mondayINedit_textbox.ForeColor = Color.White;
                mondayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                mondayOUTedit_textbox.ForeColor = Color.White;

                tuesday_label.ForeColor = Color.White;
                tuesdayINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                tuesdayINedit_textbox.ForeColor = Color.White;
                tuesdayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                tuesdayOUTedit_textbox.ForeColor = Color.White;

                wednesday_label.ForeColor = Color.White;
                wednesdayedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                wednesdayedit_textbox.ForeColor = Color.White;
                wednesdayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                wednesdayOUTedit_textbox.ForeColor = Color.White;

                thursday_label.ForeColor = Color.White;
                thursdayINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                thursdayINedit_textbox.ForeColor = Color.White;
                thursdayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                thursdayOUTedit_textbox.ForeColor = Color.White;

                friday_label.ForeColor = Color.White;
                fridayINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                fridayINedit_textbox.ForeColor = Color.White;
                fridayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                fridayOUTedit_textbox.ForeColor = Color.White;

                saturday_label.ForeColor = Color.White;
                satudayINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                satudayINedit_textbox.ForeColor = Color.White;
                saturdayOUTedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                saturdayOUTedit_textbox.ForeColor = Color.White;

                ein_label.ForeColor = Color.White;
                EINedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                EINedit_textbox.ForeColor = Color.White;

                firstname_label.ForeColor = Color.White;
                firstnameedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                firstnameedit_textbox.ForeColor = Color.White;

                lastname_label.ForeColor = Color.White;
                lastnameedit_textbox.BackColor = Color.FromArgb(163, 163, 163);
                lastnameedit_textbox.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(220, 222, 224);
                in_label.ForeColor = Color.Black;
                out_label.ForeColor = Color.Black;

                sunday_label.ForeColor = Color.Black;
                sundayINedit_textbox.BackColor = Color.White;
                sundayINedit_textbox.ForeColor = Color.Black;
                sundayOUTedit_textbox.BackColor = Color.White;
                sundayOUTedit_textbox.ForeColor = Color.Black;

                monday_label.ForeColor = Color.Black;
                mondayINedit_textbox.BackColor = Color.White;
                mondayINedit_textbox.ForeColor = Color.Black;
                mondayOUTedit_textbox.BackColor = Color.White;
                mondayOUTedit_textbox.ForeColor = Color.Black;

                tuesday_label.ForeColor = Color.Black;
                tuesdayINedit_textbox.BackColor = Color.White;
                tuesdayINedit_textbox.ForeColor = Color.Black;
                tuesdayOUTedit_textbox.BackColor = Color.White;
                tuesdayOUTedit_textbox.ForeColor = Color.Black;

                wednesday_label.ForeColor = Color.Black;
                wednesdayedit_textbox.BackColor = Color.White;
                wednesdayedit_textbox.ForeColor = Color.Black;
                wednesdayOUTedit_textbox.BackColor = Color.White;
                wednesdayOUTedit_textbox.ForeColor = Color.Black;

                thursday_label.ForeColor = Color.Black;
                thursdayINedit_textbox.BackColor = Color.White;
                thursdayINedit_textbox.ForeColor = Color.Black;
                thursdayOUTedit_textbox.BackColor = Color.White;
                thursdayOUTedit_textbox.ForeColor = Color.Black;

                friday_label.ForeColor = Color.Black;
                fridayINedit_textbox.BackColor = Color.White;
                fridayINedit_textbox.ForeColor = Color.Black;
                fridayOUTedit_textbox.BackColor = Color.White;
                fridayOUTedit_textbox.ForeColor = Color.Black;

                saturday_label.ForeColor = Color.Black;
                satudayINedit_textbox.BackColor = Color.White;
                satudayINedit_textbox.ForeColor = Color.Black;
                saturdayOUTedit_textbox.BackColor = Color.White;
                saturdayOUTedit_textbox.ForeColor = Color.Black;

                ein_label.ForeColor = Color.Black;
                EINedit_textbox.BackColor = Color.White;
                EINedit_textbox.ForeColor = Color.White;

                firstname_label.ForeColor = Color.Black;
                firstnameedit_textbox.BackColor = Color.White;
                firstnameedit_textbox.ForeColor = Color.Black;

                lastname_label.ForeColor = Color.Black;
                lastnameedit_textbox.BackColor = Color.White;
                lastnameedit_textbox.ForeColor = Color.Black;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //create strings to grab textbox information
            string EIN, FirstName, LastName, SundayIN, SundayOUT,
                MondayIN, MondayOUT, TuesdayIN, TuesdayOUT, WednesdayIN, WednesdayOUT,
                ThursdayIN, ThursdayOUT, FridayIN, FridayOUT, SaturdayIN, SaturdayOUT;

            EIN = EINedit_textbox.Text;
            FirstName = firstnameedit_textbox.Text;
            LastName = lastnameedit_textbox.Text;
            SundayIN = sundayINedit_textbox.Text;
            SundayOUT = sundayOUTedit_textbox.Text;
            MondayIN = mondayINedit_textbox.Text;
            MondayOUT = mondayOUTedit_textbox.Text;
            TuesdayIN = tuesdayINedit_textbox.Text;
            TuesdayOUT = tuesdayOUTedit_textbox.Text;
            WednesdayIN = wednesdayedit_textbox.Text;
            WednesdayOUT = wednesdayOUTedit_textbox.Text;
            ThursdayIN = thursdayINedit_textbox.Text;
            ThursdayOUT = thursdayOUTedit_textbox.Text;
            FridayIN = fridayINedit_textbox.Text;
            FridayOUT = fridayOUTedit_textbox.Text;
            SaturdayIN = satudayINedit_textbox.Text;
            SaturdayOUT = saturdayOUTedit_textbox.Text;

            //open and check connection state
            cnEmployee.Open();
            if(cnEmployee.State == ConnectionState.Open)
            {
                //create command text to edit current record
              string commandText = "UPDATE employee  SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', SundayIN = '" + SundayIN + "', SundayOUT = '" + SundayOUT + "', MondayIN = '" + MondayIN + "', MondayOUT = '" + MondayOUT + "', " +
                "TuesdayIN = '" + TuesdayIN + "', TuesdayOUT = '" + TuesdayOUT + "', WednesdayIN = '" + WednesdayIN + "', WednesdayOUT = '" + WednesdayOUT + "'," +
                " ThursdayIN = '" + ThursdayIN + "', ThursdayOUT = '" + ThursdayOUT + "', FridayIN = '" + FridayIN + "', FridayOUT = '" + FridayOUT + "', " +
                "SaturdayIN = '" + SaturdayIN + "', SaturdayOUT = '" + SaturdayOUT + "' WHERE EIN = '" + EIN + "'";
                cmdEmployee.CommandText = commandText;
                cmdEmployee.ExecuteNonQuery();
                MessageBox.Show("Saved Succesfully");
            }
            else
            {
                MessageBox.Show("Error during Save. Could not connect to database!");
            }
            
            cnEmployee.Close();
            cnEmployee.Dispose();
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
