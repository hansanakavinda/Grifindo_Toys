
namespace Grifindo_Toys
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mReg = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserReg = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmpReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mReg,
            this.mSalary,
            this.mSettings,
            this.mLogOut,
            this.mExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mReg
            // 
            this.mReg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUserReg,
            this.miEmpReg});
            this.mReg.Name = "mReg";
            this.mReg.Size = new System.Drawing.Size(219, 44);
            this.mReg.Text = "Registration";
            this.mReg.Click += new System.EventHandler(this.mReg_Click);
            // 
            // miUserReg
            // 
            this.miUserReg.Name = "miUserReg";
            this.miUserReg.Size = new System.Drawing.Size(455, 44);
            this.miUserReg.Text = "User Registration";
            this.miUserReg.Click += new System.EventHandler(this.userRegistrationToolStripMenuItem_Click);
            // 
            // miEmpReg
            // 
            this.miEmpReg.Name = "miEmpReg";
            this.miEmpReg.Size = new System.Drawing.Size(455, 44);
            this.miEmpReg.Text = "Employee Registration";
            this.miEmpReg.Click += new System.EventHandler(this.employeeRegistrationToolStripMenuItem_Click);
            // 
            // mSalary
            // 
            this.mSalary.Name = "mSalary";
            this.mSalary.Size = new System.Drawing.Size(129, 44);
            this.mSalary.Text = "Salary";
            this.mSalary.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // mSettings
            // 
            this.mSettings.Name = "mSettings";
            this.mSettings.Size = new System.Drawing.Size(158, 44);
            this.mSettings.Text = "Settings";
            this.mSettings.Click += new System.EventHandler(this.mSettings_Click);
            // 
            // mLogOut
            // 
            this.mLogOut.Name = "mLogOut";
            this.mLogOut.Size = new System.Drawing.Size(147, 44);
            this.mLogOut.Text = "Log out";
            this.mLogOut.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // mExit
            // 
            this.mExit.BackColor = System.Drawing.Color.Crimson;
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(91, 44);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.lblWelcome.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.lblWelcome.Location = new System.Drawing.Point(22, 76);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(118, 42);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "label1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(182)))), ((int)(((byte)(249)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(701, 704);
            this.ControlBox = false;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mReg;
        private System.Windows.Forms.ToolStripMenuItem miUserReg;
        private System.Windows.Forms.ToolStripMenuItem miEmpReg;
        private System.Windows.Forms.ToolStripMenuItem mSalary;
        private System.Windows.Forms.ToolStripMenuItem mSettings;
        private System.Windows.Forms.ToolStripMenuItem mLogOut;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.Label lblWelcome;
    }
}