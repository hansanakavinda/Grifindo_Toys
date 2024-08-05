
namespace Grifindo_Toys
{
    partial class SalarySettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalarySettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeavesPerEmp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHolidays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Settings";
            // 
            // txtStartdate
            // 
            this.txtStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartdate.Location = new System.Drawing.Point(158, 50);
            this.txtStartdate.Name = "txtStartdate";
            this.txtStartdate.Size = new System.Drawing.Size(200, 34);
            this.txtStartdate.TabIndex = 1;
            this.txtStartdate.ValueChanged += new System.EventHandler(this.txtStartdate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "No of Leaves per Employee for a year";
            // 
            // txtLeavesPerEmp
            // 
            this.txtLeavesPerEmp.Location = new System.Drawing.Point(554, 352);
            this.txtLeavesPerEmp.Name = "txtLeavesPerEmp";
            this.txtLeavesPerEmp.Size = new System.Drawing.Size(100, 34);
            this.txtLeavesPerEmp.TabIndex = 5;
            this.txtLeavesPerEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeavesPerEmp_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStartdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(57, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary cycle date range";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEndDate.Location = new System.Drawing.Point(528, 50);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(200, 34);
            this.txtEndDate.TabIndex = 4;
            this.txtEndDate.ValueChanged += new System.EventHandler(this.txtEndDate_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnSave.Location = new System.Drawing.Point(348, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDays
            // 
            this.txtDays.Enabled = false;
            this.txtDays.Location = new System.Drawing.Point(554, 249);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 34);
            this.txtDays.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date range";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(781, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHolidays
            // 
            this.txtHolidays.Location = new System.Drawing.Point(554, 299);
            this.txtHolidays.Name = "txtHolidays";
            this.txtHolidays.Size = new System.Drawing.Size(100, 34);
            this.txtHolidays.TabIndex = 12;
            this.txtHolidays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHolidays_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "No of holidays ";
            // 
            // SalarySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(846, 482);
            this.ControlBox = false;
            this.Controls.Add(this.txtHolidays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLeavesPerEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalarySettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SalarySettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtStartdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeavesPerEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHolidays;
        private System.Windows.Forms.Label label6;
    }
}