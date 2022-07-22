namespace Tasks1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.grpUpcoming = new System.Windows.Forms.GroupBox();
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOverdue = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.grpCompleted = new System.Windows.Forms.GroupBox();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTotalTasks = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdAddTask = new System.Windows.Forms.Button();
            this.cmdEditTask = new System.Windows.Forms.Button();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.grpUpcoming.SuspendLayout();
            this.grpOverdue.SuspendLayout();
            this.grpCompleted.SuspendLayout();
            this.grpTotalTasks.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTaskType
            // 
            this.cmbTaskType.FormattingEnabled = true;
            this.cmbTaskType.Location = new System.Drawing.Point(12, 98);
            this.cmbTaskType.Name = "cmbTaskType";
            this.cmbTaskType.Size = new System.Drawing.Size(433, 31);
            this.cmbTaskType.TabIndex = 0;
            this.cmbTaskType.SelectedIndexChanged += new System.EventHandler(this.cmbTaskType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Type";
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 23;
            this.lstTasks.Location = new System.Drawing.Point(12, 135);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(433, 372);
            this.lstTasks.TabIndex = 2;
            // 
            // grpUpcoming
            // 
            this.grpUpcoming.BackColor = System.Drawing.Color.Blue;
            this.grpUpcoming.Controls.Add(this.lblUpcoming);
            this.grpUpcoming.Controls.Add(this.label2);
            this.grpUpcoming.ForeColor = System.Drawing.Color.Blue;
            this.grpUpcoming.Location = new System.Drawing.Point(460, 98);
            this.grpUpcoming.Name = "grpUpcoming";
            this.grpUpcoming.Size = new System.Drawing.Size(200, 200);
            this.grpUpcoming.TabIndex = 3;
            this.grpUpcoming.TabStop = false;
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.ForeColor = System.Drawing.Color.White;
            this.lblUpcoming.Location = new System.Drawing.Point(87, 94);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(21, 23);
            this.lblUpcoming.TabIndex = 8;
            this.lblUpcoming.Text = "0";
            this.lblUpcoming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Upcoming";
            // 
            // grpOverdue
            // 
            this.grpOverdue.BackColor = System.Drawing.Color.Red;
            this.grpOverdue.Controls.Add(this.label3);
            this.grpOverdue.Controls.Add(this.lblOverdue);
            this.grpOverdue.ForeColor = System.Drawing.Color.White;
            this.grpOverdue.Location = new System.Drawing.Point(666, 97);
            this.grpOverdue.Name = "grpOverdue";
            this.grpOverdue.Size = new System.Drawing.Size(200, 200);
            this.grpOverdue.TabIndex = 4;
            this.grpOverdue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Overdue";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Location = new System.Drawing.Point(84, 95);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(21, 23);
            this.lblOverdue.TabIndex = 0;
            this.lblOverdue.Text = "0";
            this.lblOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCompleted
            // 
            this.grpCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grpCompleted.Controls.Add(this.lblCompleted);
            this.grpCompleted.Controls.Add(this.label4);
            this.grpCompleted.ForeColor = System.Drawing.Color.Black;
            this.grpCompleted.Location = new System.Drawing.Point(666, 303);
            this.grpCompleted.Name = "grpCompleted";
            this.grpCompleted.Size = new System.Drawing.Size(200, 200);
            this.grpCompleted.TabIndex = 5;
            this.grpCompleted.TabStop = false;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(98, 101);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(21, 23);
            this.lblCompleted.TabIndex = 3;
            this.lblCompleted.Text = "0";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Completed";
            // 
            // grpTotalTasks
            // 
            this.grpTotalTasks.BackColor = System.Drawing.Color.White;
            this.grpTotalTasks.Controls.Add(this.label5);
            this.grpTotalTasks.Controls.Add(this.lblTotalTasks);
            this.grpTotalTasks.ForeColor = System.Drawing.Color.Black;
            this.grpTotalTasks.Location = new System.Drawing.Point(460, 303);
            this.grpTotalTasks.Name = "grpTotalTasks";
            this.grpTotalTasks.Size = new System.Drawing.Size(200, 200);
            this.grpTotalTasks.TabIndex = 6;
            this.grpTotalTasks.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Tasks";
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.BackColor = System.Drawing.Color.White;
            this.lblTotalTasks.Location = new System.Drawing.Point(87, 101);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(21, 23);
            this.lblTotalTasks.TabIndex = 4;
            this.lblTotalTasks.Text = "0";
            this.lblTotalTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(114, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(218, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "John Sowell Wrote This";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAddTask
            // 
            this.cmdAddTask.Location = new System.Drawing.Point(12, 513);
            this.cmdAddTask.Name = "cmdAddTask";
            this.cmdAddTask.Size = new System.Drawing.Size(169, 37);
            this.cmdAddTask.TabIndex = 9;
            this.cmdAddTask.Text = "Add Task";
            this.cmdAddTask.UseVisualStyleBackColor = true;
            this.cmdAddTask.Click += new System.EventHandler(this.cmdAddTask_Click);
            // 
            // cmdEditTask
            // 
            this.cmdEditTask.Location = new System.Drawing.Point(276, 513);
            this.cmdEditTask.Name = "cmdEditTask";
            this.cmdEditTask.Size = new System.Drawing.Size(169, 37);
            this.cmdEditTask.TabIndex = 10;
            this.cmdEditTask.Text = "Edit Task";
            this.cmdEditTask.UseVisualStyleBackColor = true;
            this.cmdEditTask.Click += new System.EventHandler(this.cmdEditTask_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.cmdEditTask);
            this.Controls.Add(this.cmdAddTask);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpTotalTasks);
            this.Controls.Add(this.grpCompleted);
            this.Controls.Add(this.grpOverdue);
            this.Controls.Add(this.grpUpcoming);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTaskType);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpUpcoming.ResumeLayout(false);
            this.grpUpcoming.PerformLayout();
            this.grpOverdue.ResumeLayout(false);
            this.grpOverdue.PerformLayout();
            this.grpCompleted.ResumeLayout(false);
            this.grpCompleted.PerformLayout();
            this.grpTotalTasks.ResumeLayout(false);
            this.grpTotalTasks.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.GroupBox grpUpcoming;
        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOverdue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.GroupBox grpCompleted;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpTotalTasks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button cmdAddTask;
        private System.Windows.Forms.Button cmdEditTask;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}