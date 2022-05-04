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
        public edit_employee()
        {
            InitializeComponent();
        }

        private void edit_employee_Load(object sender, EventArgs e)
        {

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
