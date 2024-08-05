using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // give access according to user type
            if (loginForm.type == "Admin")
            {
                mReg.Visible = true;
                mSettings.Visible = true;
            } else
            {
                mReg.Visible = false;
                mSettings.Visible = false;
            }
            
            lblWelcome.Text = "Welcome " + loginForm.name + " to Grifindo Toys";
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // natigates to user registration form
            Form next = new userRegForm();
            this.Hide();
            next.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit
            DialogResult result = MessageBox.Show("Are you sure you want to EXIT?", "Conform to Exti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                Application.Exit();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // back to login form
            DialogResult result = MessageBox.Show("Are you sure you want to LOGOUT?", "Confirm to LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                Form back = new loginForm();
                this.Close();
                back.Show();
            }
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // move to employee registration form
            Form next= new EmpRegForm();
            this.Hide();
            next.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // move to salary calculation form
            Form next = new salaryCalForm();
            this.Hide();
            next.Show();
        }

        private void mSettings_Click(object sender, EventArgs e)
        {
            // move to salary settings form
            Form next = new SalarySettingsForm();
            this.Hide();
            next.Show();
        }

        private void mReg_Click(object sender, EventArgs e)
        {

        }
    }
}
