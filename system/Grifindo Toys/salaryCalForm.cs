using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Toys
{
    public partial class salaryCalForm : Form
    {
        public salaryCalForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=BADASS;Initial Catalog=GrifindoToys;Integrated Security=True");


        string query, eid;
        double monthlySalary, overTimeHourlyRate, allowance, overTimeHours, dateRange, basePay, noPayValue, absentDays, grossPay, tax;

       

        private void txtTax_KeyPress(object sender, KeyPressEventArgs e) // tax textbox
        {
            if (char.IsControl(e.KeyChar)) // gets control key input
            {
                return;
            }
            // Allow digits and decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore non-digit and non-decimal point input
                return;
            }
        }

        private void txtOvertime_KeyPress(object sender, KeyPressEventArgs e) // overtime textbox
        {
            // gets only digits as input
            if (char.IsControl(e.KeyChar)) // gets control key input
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
        }
    

        private void txtAbsentdays_KeyPress(object sender, KeyPressEventArgs e) // absentdays input
        {
            // gets only digits as input
            if (char.IsControl(e.KeyChar)) // gets control key input
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
        }

        private void txtleaves_KeyPress(object sender, KeyPressEventArgs e) // leaves textbox
        {
            // gets only digits as input
            if (char.IsControl(e.KeyChar)) // gets control key input
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
        }

        private void clear()
        {   
            // reset user inputs
            cmbEmpID.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            txtleaves.Text = "0";
            txtAbsentdays.Text = "0";
            txtOvertime.Text = "0";
            txtTax.Text = "0";
            lblBasePay.Text = "";
            lblNoPay.Text = "";
            lblGrossPay.Text = "";
            cmbEmpID.Focus();
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e) // button save
        {   
            // checks for missing inputs before saving
            if (cmbEmpID.SelectedIndex > 0)
            {
                if (cmbMonth.SelectedIndex > 0)
                {
                    try
                    {
                        // save data to database
                        query = "INSERT INTO empSalary(empID,month,basePay,noPay,grossPay) VALUES('" + cmbEmpID.SelectedItem.ToString() +"','" + cmbMonth.SelectedItem.ToString() + "','" + lblBasePay.Text +"','" + lblNoPay.Text + "','" + lblGrossPay.Text + "');";
                        con.Open();
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Employee ID: " + cmbEmpID.SelectedItem.ToString() + " salary details successfully SAVED to the database!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        clear();


                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error while Saving" + Environment.NewLine + err);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Month");
                    cmbMonth.Focus();
                }
            }
            else
            {
                MessageBox.Show(" Please Select an Employee ID");
                cmbEmpID.Focus();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close form and move to main form
            DialogResult result = MessageBox.Show("Are you sure you want to EXIT?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                Form back = new mainForm();
                this.Close();
                back.Show();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e) // button calculate
        {
            // check for missing inputs before calculating 
            if (cmbEmpID.SelectedIndex > 0)
            {
                if (cmbMonth.SelectedIndex > 0)
                {
                    if (txtAbsentdays.Text == "") { txtAbsentdays.Text = "0"; }
                    if (txtleaves.Text == "") { txtleaves.Text = "0"; }
                    if (txtOvertime.Text == "") { txtOvertime.Text = "0"; }
                    if (txtTax.Text == "") { txtTax.Text = "0"; }

                    overTimeHours = double.Parse(txtOvertime.Text);
                    tax = double.Parse(txtTax.Text);
                    absentDays = double.Parse(txtAbsentdays.Text);
                    basePay = monthlySalary + allowance + (overTimeHourlyRate * overTimeHours);
                    noPayValue = (basePay / dateRange) * absentDays;
                    grossPay = basePay - (noPayValue + (basePay * tax / 100));

                    lblBasePay.Text = basePay.ToString("0.00");
                    lblGrossPay.Text = grossPay.ToString("0.00");
                    lblNoPay.Text = noPayValue.ToString("0.00");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please Select the Month");
                    cmbMonth.Focus();
                }
            }
            else
            {
                MessageBox.Show(" Please Select an Employee ID");
                cmbEmpID.Focus();

            }
           

        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get employee salary details from employee table
            try
            {
                if (cmbEmpID.SelectedIndex > 0)
                {
                    eid = cmbEmpID.SelectedItem.ToString();
                    query = "SELECT * FROM empReg WHERE EmpID = '" + eid + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {

                        monthlySalary = double.Parse(r.GetValue(9).ToString());
                        overTimeHourlyRate = double.Parse(r.GetValue(10).ToString());
                        allowance = double.Parse(r.GetValue(11).ToString());

                    }
                    con.Close();
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while getting data" + Environment.NewLine + err);
                con.Close();
            }
        }

        private void salaryCalForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false; // disable the save button until button calculation triggered
            try
            {
                // gets emplyee IDs
                query = "SELECT EmpID FROM empReg;";
                con.Open();
                adap = new SqlDataAdapter(query, con);
                DataTable tab = new DataTable();
                adap.Fill(tab);

                if (tab.Rows.Count > 0)
                {

                    cmbEmpID.Items.Clear();
                    cmbEmpID.Items.Add("--SELECT--");
                    foreach (DataRow line in tab.Rows)
                    {
                        cmbEmpID.Items.Add(line["EmpID"]);
                    }
                    cmbEmpID.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("There is no data in the database");
                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while getting data from Employee Registation table" + Environment.NewLine + err);
                
                con.Close();
            }
            clear();

            // gets salary settings details
            try
            {


                query = "SELECT * FROM salarySettings";
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    dateRange = double.Parse(r.GetValue(1).ToString());

                }
                con.Close();



            }
            catch (Exception err)
            {
                MessageBox.Show("Error while getting data from Salary Settings table" + Environment.NewLine + err);
                con.Close();
            }
        }
    }
}
