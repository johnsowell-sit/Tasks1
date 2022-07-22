using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite; // NuGet package System.Data.SQLite for SQLite functionality

namespace Tasks1
{
    public partial class frmTask : Form
    {
        const int NEW_TASK = 0;
        const int EDIT_TASK = 1;

        const int CANCELED = -1;
        const int ASSIGNED = 0;
        const int COMPLETED = 1;

        public int Action, TaskID, WorkerID;
        int AssignDate, AssignTime, DueDate, DueTime, Status, StarDate, StarTime;
        string Caption, Description, Notes, SQL;

        DateTime Present;

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public frmTask()
        {
            InitializeComponent();
        }

        // ********************************************************************

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Status = CANCELED;
        }

        // ********************************************************************

        private void cmdClose_Click(object sender, EventArgs e)
        {
            int Len;
            string ConnStr, InitDir;
            SQLiteConnection Connection;
            SQLiteCommand Command;

            InitDir = Path.GetFullPath(".");
            Len = InitDir.Length;
            InitDir = InitDir.Substring(0, Len - 10);

            ConnStr = "DataSource=" + InitDir + "\\Data\\Tasks.db;Version=3";
            Connection = new SQLiteConnection(ConnStr);
            Connection.Open();

            Caption = StringCleanUp(txtCaption.Text);
            Description = StringCleanUp(txtDescription.Text);
            Notes = StringCleanUp(txtNotes.Text);
            DueDate = (10000 * (cmbYear.SelectedIndex + 2000)) + (100 * (cmbMonth.SelectedIndex + 1)) + cmbDate.SelectedIndex + 1;
            DueTime = (100 * cmbHour.SelectedIndex) + cmbMinute.SelectedIndex;

            if (Action == NEW_TASK)
            {
                Present = DateTime.Now; // for the correct assign values
                AssignDate = (10000 * Present.Year) + (100 * Present.Month) + Present.Day;
                AssignTime = (100 * Present.Hour) + Present.Minute;
                Status = ASSIGNED;

                SQL = "INSERT INTO Task VALUES(" + TaskID.ToString() + "," + WorkerID.ToString() + "," + AssignDate.ToString() + "," + AssignTime + ",'" + Caption + "','" + Description + "'," + DueDate.ToString() + "," + DueTime.ToString() + "," + Status.ToString() + ",'" + Notes + "')";
            }

            if (Action == EDIT_TASK)
            {
                SQL = "UPDATE Task SET Caption = '" + Caption + "', Description = '" + Description + "', Notes = '" + Notes + "', DueDate = " + DueDate.ToString() + ", DueTime = " + DueTime.ToString() + ", Status = " + Status.ToString() + " WHERE TaskID = " + TaskID.ToString();
            }

            Command = new SQLiteCommand(SQL, Connection);
            Command.ExecuteNonQuery();
            MessageBox.Show("Task Information Entered/Updated!");
            Connection.Close();
            Close();
        }

        // ********************************************************************

        private void cmdComplete_Click(object sender, EventArgs e)
        {
            Status = COMPLETED;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ####################################################################

        static string StringCleanUp(string S)
        {
            int i;
            string Str = "";

            for (i = 0; i < S.Length; i++)
            {
                if ((S.Substring(i, 1) != "'") && (S.Substring(i, 1) != "&") && (S.Substring(i, 1) != "\""))
                    Str += S.Substring(i, 1);
                else
                {
                    if ((S.Substring(i, 1) == "'") || (S.Substring(i, 1) == "\""))
                        Str += "''";
                    else
                    {
                        if ((i > 0) && (S.Substring(i - 1, 1) != "&"))
                            Str += "&";
                    }
                }
            }
            return Str;
        }

        // ********************************************************************

        private void Task_Load(object sender, EventArgs e)
        {
            int x;

            Present = DateTime.Now;

            cmbMonth.Items.Add("JANUARY");
            cmbMonth.Items.Add("FEBRUARY");
            cmbMonth.Items.Add("MARCH");
            cmbMonth.Items.Add("APRIL");
            cmbMonth.Items.Add("MAY");
            cmbMonth.Items.Add("JUNE");
            cmbMonth.Items.Add("JULY");
            cmbMonth.Items.Add("AUGUST");
            cmbMonth.Items.Add("SEPTEMBER");
            cmbMonth.Items.Add("OCTOBER");
            cmbMonth.Items.Add("NOVEMBER");
            cmbMonth.Items.Add("DECEMBER");

            for (x=1; x<32; x++)
            {
                cmbDate.Items.Add(x.ToString());
            }

            for(x=2000; x<=Present.Year+30; x++)
            {
                cmbYear.Items.Add(x.ToString());
            }    
            
            for (x=0; x<24; x++)
            {
                cmbHour.Items.Add(x.ToString());
            }    

            for (x=0; x<60; x++)
            {
                if (x < 10)
                    cmbMinute.Items.Add("0" + x.ToString());
                else
                    cmbMinute.Items.Add(x.ToString());
            }

            if (Action == NEW_TASK)
            {
                cmdComplete.Enabled = false;
                cmdCancel.Enabled = false;

                txtCaption.Text = "";
                txtDescription.Text = "";
                txtNotes.Text = "";

                cmbMonth.SelectedIndex = Present.Month - 1;
                cmbDate.SelectedIndex = Present.Day - 1;
                cmbYear.SelectedIndex = Present.Year - 2000;
                cmbHour.SelectedIndex = Present.Hour;
                cmbMinute.SelectedIndex = Present.Minute;
            }

            if (Action == EDIT_TASK)
            {
                int Len, StarDate, StarTime;
                string Caption, ConnStr, Description, InitDir, Notes, SQL, StatusStr, TaskStr;
                DateTime Present = DateTime.Now;
                SQLiteConnection Connection;
                SQLiteCommand Command;
                SQLiteDataReader Reader;

                StarDate = (10000 * Present.Year) + (100 * Present.Month) + Present.Day;
                StarTime = (100 * Present.Hour) + Present.Minute;


                InitDir = Path.GetFullPath(".");
                Len = InitDir.Length;
                InitDir = InitDir.Substring(0, Len - 10);

                ConnStr = "DataSource=" + InitDir + "\\Data\\Tasks.db;Version=3";
                Connection = new SQLiteConnection(ConnStr);
                Connection.Open();

                SQL = "SELECT * FROM Task WHERE TaskID = " + TaskID.ToString();
                Command = new SQLiteCommand(SQL, Connection);
                Reader = Command.ExecuteReader();
                while(Reader.Read() == true)
                {
                    Caption = Reader["Caption"].ToString();
                    Description = Reader["Description"].ToString();
                    StarDate = Convert.ToInt32(Reader["DueDate"]);
                    StarTime = Convert.ToInt32(Reader["DueTime"]);
                    Notes = Reader["Notes"].ToString();
                    Status = Convert.ToInt32(Reader["Status"]);

                    txtCaption.Text = Caption;
                    txtDescription.Text = Description;
                    txtNotes.Text = Notes;
                    cmbMonth.SelectedIndex = ((StarDate % 10000) / 100) - 1;
                    cmbDate.SelectedIndex = (StarDate % 100) - 1;
                    cmbYear.SelectedIndex = (StarDate / 10000) - 2000;
                    cmbHour.SelectedIndex = StarTime / 100;
                    cmbMinute.SelectedIndex = StarTime % 100;
                }

                Reader.Close();
                Connection.Close();
            }
        }

        // ********************************************************************

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            cmdClose.Enabled = (txtCaption.Text.Length > 0);
        }

    }
}