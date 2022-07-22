namespace Tasks1
{
    partial class frmTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdComplete = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(16, 80);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(434, 30);
            this.txtCaption.TabIndex = 2;
            this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 153);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(434, 95);
            this.txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Due Date And Time";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(2, 338);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(148, 31);
            this.cmbMonth.TabIndex = 6;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(156, 338);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(66, 31);
            this.cmbDate.TabIndex = 7;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(228, 338);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(78, 31);
            this.cmbYear.TabIndex = 8;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(312, 338);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(66, 31);
            this.cmbHour.TabIndex = 9;
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Location = new System.Drawing.Point(384, 338);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(66, 31);
            this.cmbMinute.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Minute";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 421);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(434, 95);
            this.txtNotes.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Additional Notes";
            // 
            // cmdComplete
            // 
            this.cmdComplete.Location = new System.Drawing.Point(12, 538);
            this.cmdComplete.Name = "cmdComplete";
            this.cmdComplete.Size = new System.Drawing.Size(196, 33);
            this.cmdComplete.TabIndex = 18;
            this.cmdComplete.Text = "Complete Task";
            this.cmdComplete.UseVisualStyleBackColor = true;
            this.cmdComplete.Click += new System.EventHandler(this.cmdComplete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(259, 538);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(196, 33);
            this.cmdCancel.TabIndex = 19;
            this.cmdCancel.Text = "Cancel Task";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(5, 577);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(441, 33);
            this.cmdClose.TabIndex = 20;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 617);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdComplete);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMinute);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdComplete;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdClose;
    }
}