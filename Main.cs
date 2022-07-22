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
    //  $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $

    public partial class frmMain : Form
    {
        public struct TASK
        {
            public int ID, Status;
            public string Caption;
        }

        const int UPCOMING_TASKS  = 0;
        const int OVERDUE_TASKS   = 1;
        const int COMPLETED_TASKS = 2;
        const int ALL_TASKS       = 3;

        const int CANCELED        = -1;
        const int ASSIGNED        = 0;
        const int COMPLETED       = 1;

        const int NEW_TASK = 0;
        const int EDIT_TASK = 1;

        public List<TASK> TaskList = new List<TASK>();

        public int GrandTotalTasks, TotalTasks, WorkerID;
        public string WorkerName;

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public frmMain()
        {
            InitializeComponent();
        }

        // ********************************************************************

        private void cmbTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaskList(cmbTaskType.SelectedIndex);
        }

        // ********************************************************************

        private void cmdAddTask_Click(object sender, EventArgs e)
        {
            frmTask dlg = new frmTask();
            dlg.Action = NEW_TASK;
            dlg.TaskID = GrandTotalTasks + 1;
            dlg.WorkerID = WorkerID;
            dlg.ShowDialog();
            LoadTaskList(ALL_TASKS);
            cmbTaskType.SelectedIndex = ALL_TASKS;
            UpdateCounts();
        }

        // ********************************************************************

        private void cmdEditTask_Click(object sender, EventArgs e)
        {
            int i = lstTasks.SelectedIndex;

            frmTask dlg = new frmTask();
            dlg.Action = EDIT_TASK;
            dlg.TaskID = TaskList[i].ID;
            dlg.WorkerID = WorkerID;
            dlg.ShowDialog();
            LoadTaskList(ALL_TASKS);
            cmbTaskType.SelectedIndex = ALL_TASKS;
            UpdateCounts();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        // ********************************************************************

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblName.Text = "Tasks For " + WorkerName;

            cmdEditTask.Enabled = false;
            toolStripButton2.Enabled = false;
            TaskList.Clear();

            cmbTaskType.Items.Add("UPCOMING TASKS");
            cmbTaskType.Items.Add("OVERDUE TASKS");
            cmbTaskType.Items.Add("COMPLETED TASKS");
            cmbTaskType.Items.Add("ALL TASKS");
            cmbTaskType.SelectedIndex = ALL_TASKS;

            UpdateCounts();
            LoadTaskList(ALL_TASKS);
        }

        // ********************************************************************

        public void LoadTaskList(int TaskType)
        {
            int ID, Len, StarDate,StarTime, Status;
            string Caption, ConnStr, InitDir, SQL, StatusStr, TaskStr;
            TASK TempTask;
            DateTime Present = DateTime.Now;
            SQLiteConnection Connection;
            SQLiteCommand Command;
            SQLiteDataReader Reader;

            StarDate = (10000 * Present.Year) + (100 * Present.Month) + Present.Day;
            StarTime = (100 * Present.Hour) + Present.Minute;

            lstTasks.Items.Clear();
            cmdEditTask.Enabled = false;
            toolStripButton2.Enabled = false;


            InitDir = Path.GetFullPath(".");
            Len = InitDir.Length;
            InitDir = InitDir.Substring(0, Len - 10);

            ConnStr = "DataSource=" + InitDir + "\\Data\\Tasks.db;Version=3";
            Connection = new SQLiteConnection(ConnStr);
            Connection.Open();

            SQL = "";
            switch(TaskType)
            {
                case UPCOMING_TASKS:
                    SQL = "SELECT * FROM Task WHERE WorkerID = " + WorkerID.ToString() + " AND Status = " + ASSIGNED.ToString() + " AND DueDate > " + StarDate.ToString() + " OR (DueDate = " + StarDate.ToString() + " AND (DueTime >= " + StarTime.ToString() + ")";
                    break;

                case OVERDUE_TASKS:
                    SQL = "SELECT * FROM Task WHERE WorkerID = " + WorkerID.ToString() + " AND Status = " + ASSIGNED.ToString() + " AND DueDate < " + StarDate.ToString() + " OR (DueDate = " + StarDate.ToString() + " AND (DueTime < " + StarTime.ToString() + ")";
                    break;

                case COMPLETED_TASKS:
                    SQL = "SELECT * FROM Task WHERE WorkerID = " + WorkerID.ToString() + " AND Status = " +  COMPLETED.ToString();
                    break;

                case ALL_TASKS:
                    SQL = "SELECT * FROM Task WHERE WorkerID = " + WorkerID.ToString();
                    break;
            }

            Command = new SQLiteCommand(SQL, Connection);
            Reader = Command.ExecuteReader();
            while (Reader.Read() == true)
            {
                ID = Convert.ToInt32(Reader["TaskID"]);
                Caption = Reader["Caption"].ToString();
                Status = Convert.ToInt32(Reader["Status"]);
                TempTask.ID = ID;
                TempTask.Caption = Caption;
                TempTask.Status = Status;
                TaskList.Add(TempTask);

                StatusStr = "ASSIGNED";
                if (Status == CANCELED)
                    StatusStr = "CANCELED";
                if (Status == ASSIGNED)
                {
                    if (TaskType == UPCOMING_TASKS)
                        StatusStr = "UPCOMING";
                    if (TaskType == OVERDUE_TASKS)
                        StatusStr = "OVERDUE";
                }
                if (Status == COMPLETED)
                    StatusStr = "COMPLETED";

                TaskStr = "TASK " + ID.ToString() + " ---> " + Caption + " (" + StatusStr + ")";
                lstTasks.Items.Add(TaskStr);
                cmdEditTask.Enabled = true;
                toolStripButton2.Enabled = true;
            }

            Reader.Close();
            lstTasks.SelectedIndex = lstTasks.Items.Count - 1;
            Connection.Close();
        }

        // ********************************************************************

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTask dlg = new frmTask();
            dlg.Action = NEW_TASK;
            dlg.TaskID = GrandTotalTasks + 1;
            dlg.WorkerID = WorkerID;
            dlg.ShowDialog();
            LoadTaskList(ALL_TASKS);
            cmbTaskType.SelectedIndex = ALL_TASKS;
            UpdateCounts();
        }

        // ********************************************************************

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int i = lstTasks.SelectedIndex;

            frmTask dlg = new frmTask();
            dlg.Action = EDIT_TASK;
            dlg.TaskID = TaskList[i].ID;
            dlg.WorkerID = WorkerID;
            dlg.ShowDialog();
            LoadTaskList(ALL_TASKS);
            cmbTaskType.SelectedIndex = ALL_TASKS;
            UpdateCounts();
        }

        // ********************************************************************

        public void UpdateCounts()
        {
            int Count, Len, StarDate, StarTime;
            string ConnStr, InitDir, SQL;

            DateTime Present = DateTime.Now;
            SQLiteConnection Connection;
            SQLiteCommand Command, Command2, Command3, Command4, Command5;
            SQLiteDataReader Reader, Reader2, Reader3, Reader4, Reader5;

            StarDate = (10000 * Present.Year) + (100 * Present.Month) + Present.Day;
            StarTime = (100 * Present.Hour) + Present.Minute;

            InitDir = Path.GetFullPath(".");
            Len = InitDir.Length;
            InitDir = InitDir.Substring(0, Len - 10);

            ConnStr = "DataSource=" + InitDir + "\\Data\\Tasks.db;Version=3";
            Connection = new SQLiteConnection(ConnStr);
            Connection.Open();

            SQL = "SELECT COUNT(*) FROM task WHERE WorkerID = " + WorkerID.ToString();
            Command = new SQLiteCommand(SQL, Connection);
            Reader = Command.ExecuteReader();
            Count = 0;
            while (Reader.Read() == true)
            {
                Count = Convert.ToInt32(Reader[0]);
            }
            lblTotalTasks.Text = Count.ToString();
            TotalTasks = Count;
            Reader.Close();
            Connection.Close();

            SQL = "SELECT COUNT(*) FROM task WHERE WorkerID = " + WorkerID.ToString() + " AND Status = " + COMPLETED.ToString();
            Connection.Open();
            Command2 = new SQLiteCommand(SQL, Connection);
            Reader2 = Command2.ExecuteReader();
            Count = 0;
            while (Reader2.Read() == true)
            {
                Count = Convert.ToInt32(Reader2[0]);
            }
            lblCompleted.Text = Count.ToString();
            Reader2.Close();
            Connection.Close();

            SQL = "SELECT COUNT(*) FROM task WHERE WorkerID = " + WorkerID.ToString() + " AND Status = " + ASSIGNED.ToString() + " AND (DueDate > " + StarDate.ToString() + " OR (DueDate = " + StarDate.ToString() + " AND DueTime >= " + StarTime.ToString() + "))";
            Connection.Open();
            Command3 = new SQLiteCommand(SQL, Connection);
            Reader3 = Command3.ExecuteReader();
            Count = 0;
            while (Reader3.Read() == true)
            {
                Count = Convert.ToInt32(Reader3[0]);
            }
            lblUpcoming.Text = Count.ToString();
            Reader3.Close();
            Connection.Close();

            SQL = "SELECT COUNT(*) FROM task WHERE WorkerID = " + WorkerID.ToString() + " AND Status = " + ASSIGNED.ToString() + " AND (DueDate < " + StarDate.ToString() + " OR (DueDate = " + StarDate.ToString() + " AND DueTime < " + StarTime.ToString() + "))";
            Connection.Open();
            Command4 = new SQLiteCommand(SQL, Connection);
            Reader4 = Command4.ExecuteReader();
            Count = 0;
            while (Reader4.Read() == true)
            {
                Count = Convert.ToInt32(Reader4[0]);
            }
            lblOverdue.Text = Count.ToString();
            Reader4.Close();
            Connection.Close();

            SQL = "SELECT COUNT(*) FROM task";
            Connection.Open();
            Command5 = new SQLiteCommand(SQL, Connection);
            Reader5 = Command5.ExecuteReader();
            Count = 0;
            while (Reader5.Read() == true)
            {
                Count = Convert.ToInt32(Reader5[0]);
            }
            GrandTotalTasks = Count;
            Reader5.Close();
            Connection.Close();
        }
    }
}