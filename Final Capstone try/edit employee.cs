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

            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
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


            cnEmployee.Open();
            if(cnEmployee.State == ConnectionState.Open)
            {
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
                MessageBox.Show("Error during Save");
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
