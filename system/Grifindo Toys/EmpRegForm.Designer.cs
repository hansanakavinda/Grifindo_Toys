
namespace Grifindo_Toys
{
    partial class EmpRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpRegForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSalaryDetails = new System.Windows.Forms.GroupBox();
            this.txtAllowances = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOTHourlyRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.rbUnmarried = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbSalaryDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // gbSalaryDetails
            // 
            this.gbSalaryDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.gbSalaryDetails.Controls.Add(this.txtAllowances);
            this.gbSalaryDetails.Controls.Add(this.label11);
            this.gbSalaryDetails.Controls.Add(this.txtOTHourlyRate);
            this.gbSalaryDetails.Controls.Add(this.label10);
            this.gbSalaryDetails.Controls.Add(this.txtMonthlySalary);
            this.gbSalaryDetails.Controls.Add(this.label9);
            this.gbSalaryDetails.Location = new System.Drawing.Point(42, 386);
            this.gbSalaryDetails.Name = "gbSalaryDetails";
            this.gbSalaryDetails.Size = new System.Drawing.Size(517, 217);
            this.gbSalaryDetails.TabIndex = 8;
            this.gbSalaryDetails.TabStop = false;
            this.gbSalaryDetails.Text = "Salary Details";
            // 
            // txtAllowances
            // 
            this.txtAllowances.Location = new System.Drawing.Point(271, 150);
            this.txtAllowances.Name = "txtAllowances";
            this.txtAllowances.Size = new System.Drawing.Size(133, 34);
            this.txtAllowances.TabIndex = 13;
            this.txtAllowances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAllowances_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Allowances";
            // 
            // txtOTHourlyRate
            // 
            this.txtOTHourlyRate.Location = new System.Drawing.Point(271, 104);
            this.txtOTHourlyRate.Name = "txtOTHourlyRate";
            this.txtOTHourlyRate.Size = new System.Drawing.Size(133, 34);
            this.txtOTHourlyRate.TabIndex = 12;
            this.txtOTHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTHourlyRate_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Overtime Hourly Rate";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Location = new System.Drawing.Point(271, 52);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(133, 34);
            this.txtMonthlySalary.TabIndex = 11;
            this.txtMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonthlySalary_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Monthly Salary";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnSave.Location = new System.Drawing.Point(296, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 41);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnUpdate.Location = new System.Drawing.Point(296, 634);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 41);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnClear.Location = new System.Drawing.Point(439, 634);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 41);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(79, 634);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(208, 100);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(179, 35);
            this.cmbEmpID.TabIndex = 13;
            this.cmbEmpID.Visible = false;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(208, 256);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(179, 34);
            this.txtConNo.TabIndex = 3;
            this.txtConNo.TextChanged += new System.EventHandler(this.txtConNo_TextChanged);
            this.txtConNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConNo_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(519, 97);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 120);
            this.txtAddress.TabIndex = 6;
            // 
            // txtDOB
            // 
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDOB.Location = new System.Drawing.Point(208, 307);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(179, 34);
            this.txtDOB.TabIndex = 4;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(21, 33);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(88, 33);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(21, 67);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(116, 33);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(6, 33);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(121, 33);
            this.rbMarried.TabIndex = 9;
            this.rbMarried.TabStop = true;
            this.rbMarried.Text = "Married";
            this.rbMarried.UseVisualStyleBackColor = true;
            // 
            // rbUnmarried
            // 
            this.rbUnmarried.AutoSize = true;
            this.rbUnmarried.Location = new System.Drawing.Point(6, 61);
            this.rbUnmarried.Name = "rbUnmarried";
            this.rbUnmarried.Size = new System.Drawing.Size(153, 33);
            this.rbUnmarried.TabIndex = 10;
            this.rbUnmarried.TabStop = true;
            this.rbUnmarried.Text = "Unmarried";
            this.rbUnmarried.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(777, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 42);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(203, 100);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(39, 29);
            this.lblEmpID.TabIndex = 24;
            this.lblEmpID.Text = "00";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(339, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 40);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(208, 204);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(179, 34);
            this.txtNIC.TabIndex = 2;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            this.txtNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIC_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "NIC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUnmarried);
            this.groupBox1.Controls.Add(this.rbMarried);
            this.groupBox1.Location = new System.Drawing.Point(608, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 106);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Civilstatus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Location = new System.Drawing.Point(422, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 106);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // EmpRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(840, 692);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbEmpID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSalaryDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EmpRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            this.Load += new System.EventHandler(this.EmpRegForm_Load);
            this.gbSalaryDetails.ResumeLayout(false);
            this.gbSalaryDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbSalaryDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAllowances;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOTHourlyRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.RadioButton rbUnmarried;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}