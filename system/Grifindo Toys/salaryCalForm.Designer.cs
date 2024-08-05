
namespace Grifindo_Toys
{
    partial class salaryCalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salaryCalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBasePay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNoPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtleaves = new System.Windows.Forms.TextBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.txtAbsentdays = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Calculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "No of Absentdays";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Overtime Hours";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnCalculate.Location = new System.Drawing.Point(57, 428);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(183, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base Pay";
            // 
            // lblBasePay
            // 
            this.lblBasePay.AutoSize = true;
            this.lblBasePay.Location = new System.Drawing.Point(231, 484);
            this.lblBasePay.Name = "lblBasePay";
            this.lblBasePay.Size = new System.Drawing.Size(0, 29);
            this.lblBasePay.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "No Pay";
            // 
            // lblNoPay
            // 
            this.lblNoPay.AutoSize = true;
            this.lblNoPay.Location = new System.Drawing.Point(231, 526);
            this.lblNoPay.Name = "lblNoPay";
            this.lblNoPay.Size = new System.Drawing.Size(0, 29);
            this.lblNoPay.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gross Pay";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(231, 574);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(0, 29);
            this.lblGrossPay.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnSave.Location = new System.Drawing.Point(54, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtleaves
            // 
            this.txtleaves.Location = new System.Drawing.Point(267, 224);
            this.txtleaves.Name = "txtleaves";
            this.txtleaves.Size = new System.Drawing.Size(118, 34);
            this.txtleaves.TabIndex = 12;
            this.txtleaves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtleaves_KeyPress);
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(267, 323);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(118, 34);
            this.txtOvertime.TabIndex = 13;
            this.txtOvertime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOvertime_KeyPress);
            // 
            // txtAbsentdays
            // 
            this.txtAbsentdays.Location = new System.Drawing.Point(267, 275);
            this.txtAbsentdays.Name = "txtAbsentdays";
            this.txtAbsentdays.Size = new System.Drawing.Size(118, 34);
            this.txtAbsentdays.TabIndex = 14;
            this.txtAbsentdays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbsentdays_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(403, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 38);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Leaves";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee ID";
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(267, 124);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(118, 35);
            this.cmbEmpID.TabIndex = 20;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "--SELECT--",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octomber",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(267, 170);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(118, 35);
            this.cmbMonth.TabIndex = 21;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(267, 368);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(118, 34);
            this.txtTax.TabIndex = 23;
            this.txtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Government Tax";
            // 
            // salaryCalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(453, 683);
            this.ControlBox = false;
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAbsentdays);
            this.Controls.Add(this.txtOvertime);
            this.Controls.Add(this.txtleaves);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNoPay);
            this.Controls.Add(this.lblBasePay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "salaryCalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.salaryCalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBasePay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNoPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtleaves;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.TextBox txtAbsentdays;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculate;
    }
}