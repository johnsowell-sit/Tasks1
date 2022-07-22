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
            //ConnStr = "DataSource=" + DBStr + ";Version=3";

namespace Tasks1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // ********************************************************************

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ********************************************************************

        private void cmdEnter_Click(object sender, EventArgs e)
        {
            bool Found;
            int ID,Len;
            string ConnStr, InitDir, Name, Password, UserName;
            frmMain dlg = new frmMain();
            SQLiteCommand Command;
            SQLiteConnection Connection;
            SQLiteDataReader Reader;

            InitDir = Path.GetFullPath(".");
            Len = InitDir.Length;
            InitDir = InitDir.Substring(0, Len - 10);

            ID = 0;
            Name = "";

            ConnStr = "DataSource=" + InitDir + "\\Data\\Tasks.db;Version=3";
            Connection = new SQLiteConnection(ConnStr);
            Connection.Open();
            Command = new SQLiteCommand("SELECT * FROM Worker", Connection);
            Reader = Command.ExecuteReader();
            Found = false;
            while(Reader.Read())
            {
                ID = Convert.ToInt32(Reader[0]);
                Name = Reader[1].ToString();
                UserName = Reader[2].ToString();
                Password = Reader[3].ToString();

                if ((txtUserName.Text == UserName) && (txtPassword.Text == Password))
                {
                    Found = true;
                    break;
                }
            }

            Reader.Close();            
            Connection.Close();
            if (Found == true)
            {
                dlg.WorkerID = ID;
                dlg.WorkerName = Name;
                dlg.ShowDialog();
                Close();
            }
            else
                lblError.Text = "Incorrect UserName and/or Password!";
        }

        // ********************************************************************

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmdEnter.Enabled = false;
        }

        // ********************************************************************

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            cmdEnter.Enabled = (txtUserName.Text.Length > 0);
        }
    }
}