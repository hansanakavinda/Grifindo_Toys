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
    public partial class SalarySettingsForm : Form
    {
        public SalarySettingsForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=BADASS;Initial Catalog=GrifindoToys;Integrated Security=True");


        string query;
        DateTime start, end;
        int days;

        private void txtEndDate_ValueChanged(object sender, EventArgs e)
        {
            // gets changes in end date
            calculate_date_range();
        }

        private void txtStartdate_ValueChanged(object sender, EventArgs e)
        {
            // gets changes in start date
            calculate_date_range();
        }

        private void calculate_date_range() // calculate date range
        {
            start = DateTime.Parse(txtStartdate.Text);
            end = DateTime.Parse(txtEndDate.Text);
            TimeSpan dateRange = end - start;
            txtDays.Text = $"{dateRange.Days}";
            days = int.Parse(txtDays.Text);
            if (days > 31 || days < 28) // validate the date range
            {
                MessageBox.Show("Invaild Date range");
                txtDays.Text = "";
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

        private void SalarySettingsForm_Load(object sender, EventArgs e)
        {
            // gets current salary details from the database
            try
            {
                string querySearch = "SELECT * FROM salarySettings";
                con.Open();
                adap = new SqlDataAdapter(querySearch, con);
                DataTable table = new DataTable();
                adap.Fill(table);

                if (table.Rows.Count > 0)
                {
                    btnSave.Text = "Update";
                    query = "SELECT * FROM salarySettings";
                    cmd = new SqlCommand(query, con);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtDays.Text = R.GetValue(1).ToString();
                        txtLeavesPerEmp.Text = R.GetValue(2).ToString();
                        txtHolidays.Text = R.GetValue(3).ToString();
                    }

                }
               
                con.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error while Loading" + Environment.NewLine + err);
                con.Close();
            }
        }

       

        private void txtHolidays_KeyPress(object sender, KeyPressEventArgs e) // holidays textbox
        {
            // gets only numbers are user input
            if (char.IsControl(e.KeyChar)) // gets control key inputs
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
        }

        private void txtLeavesPerEmp_KeyPress(object sender, KeyPressEventArgs e) // leaves text box
        {
            // gets only numbers are user input
            if (char.IsControl(e.KeyChar)) // gets control key inputs
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) // button update
        {
            // update salary settings details to datebase
            try
            {
                int No = 1;

                if (btnSave.Text == "Update")
                {
                    query = "UPDATE salarySettings SET  DateRange= '" + txtDays.Text + "', LeavesPerYear = '" + txtLeavesPerEmp.Text + "', Holidays = '" + txtHolidays.Text + "' WHERE No= '" + No + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Salary Settings updated successfully");

                }
                else
                {

                    query = "INSERT INTO salarySettings(No,DateRange,LeavesPerYear,Holidays) VALUES('" + No + "','" + txtDays.Text + "','" + txtLeavesPerEmp.Text + "','" + txtHolidays.Text + "');";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(" Salary settings successfully SAVED to the database!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                con.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error while updating salary settings" + Environment.NewLine + err);
                con.Close();
            }

        }
    }
}
