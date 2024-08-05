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
    public partial class EmpRegForm : Form
    {
        public EmpRegForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=BADASS;Initial Catalog=GrifindoToys;Integrated Security=True");


        int serialNo ;
        string query, eid, gen, stat;
        
        private void SerialNoGenerator()
        {
            // generates serial number for the database and employee ID
            try
            {
                serialNo = 0;
                query = "SELECT SerialNo FROM empReg";
                con.Open();
                adap = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adap.Fill(table);

                if (table.Rows.Count > 0)
                {
                    query = "SELECT MAX(SerialNo) FROM empReg";
                    cmd = new SqlCommand(query, con);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        serialNo = int.Parse(R.GetValue(0).ToString());
                    }
                    serialNo += 1;
                }
                else
                {
                    serialNo = 1;
                }
                con.Close();
                if (serialNo < 10) { eid = "E00" + serialNo; }
                else if (serialNo < 100) { eid = "E0" + serialNo; }
                lblEmpID.Text = eid;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while Serial No Generation" + Environment.NewLine + err);
                con.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear button
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // search available employee in the database
            try
            {
                query = "SELECT EmpID FROM empReg;";
                con.Open();
                adap = new SqlDataAdapter(query, con);
                DataTable tab = new DataTable();
                adap.Fill(tab);

                if (tab.Rows.Count > 0)
                {
                    cmbEmpID.Visible = true;
                    lblEmpID.Visible = false;
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    btnSearch.Visible = false;
                    btnClear.Text = "Back";

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
                    clear();
                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while searching" + Environment.NewLine + err);
                btnSearch.Visible = true;
                con.Close();
            }
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get data for selected employee ID
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
                        txtName.Text = r.GetValue(2).ToString();
                        txtNIC.Text = r.GetValue(3).ToString();
                        txtConNo.Text = r.GetValue(4).ToString();
                        txtDOB.Text = r.GetValue(5).ToString();
                        txtAddress.Text = r.GetValue(6).ToString();
                        gen = r.GetValue(7).ToString();
                        stat = r.GetValue(8).ToString();
                        txtMonthlySalary.Text = r.GetValue(9).ToString();
                        txtOTHourlyRate.Text= r.GetValue(10).ToString();
                        txtAllowances.Text = r.GetValue(11).ToString();
                    }
                    if (gen.Equals("Male")) { rbMale.Checked = true; }
                    else if (gen.Equals("Female")) { rbFemale.Checked = true; }

                    if (stat.Equals("Married")) { rbMarried.Checked = true; }
                    else if (stat.Equals("Unmarried")) { rbUnmarried.Checked = true; }
                    con.Close();
                }
                else
                {
                    
                    txtName.Text = "";
                    txtNIC.Text = "";
                    txtConNo.Text = "";
                    txtDOB.Text = "";
                    txtAddress.Text = "";
                    txtMonthlySalary.Text = "";
                    txtOTHourlyRate.Text = "";
                    txtAllowances.Text = "";
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                    rbMarried.Checked = false;
                    rbUnmarried.Checked = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while getting data" + Environment.NewLine + err);
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            // button update
            if (cmbEmpID.SelectedIndex == 0)
            {
                // avoid misclicks before getting information
                MessageBox.Show("Please select an Employee ID from the list" );
                
            }
            else
            {
                // update new changes 
                try
                {
                    if (rbMale.Checked == true)
                    {
                        gen = "Male";
                    }
                    else if (rbFemale.Checked == true)
                    {
                        gen = "Female";
                    }
                    if (rbMarried.Checked == true)
                    {
                        stat = "Married";
                    }
                    else if (rbUnmarried.Checked == true)
                    {
                        stat = "Unmarried";
                    }

                    query = "UPDATE empReg SET Name = '" + txtName.Text + "', NIC = '" + txtNIC.Text + "', ConNo = '" + txtConNo.Text + "', DOB = '" + txtDOB.Text + "', EmpAddress= '" + txtAddress.Text + "', Gender= '" + gen + "', CivilStatus= '" + stat + "', MonSalary= '" + txtMonthlySalary.Text + "', OTHRate= '" + txtOTHourlyRate.Text + "', Allowance= '" + txtAllowances.Text + "' WHERE EmpID= '" + cmbEmpID.SelectedItem.ToString() + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee ID: " + cmbEmpID.SelectedItem.ToString() + " updated successfully");
                    clear();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error while updating" + Environment.NewLine + err);
                    con.Close();
                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete seleted employee details
            try
            {
                eid = cmbEmpID.SelectedItem.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want to DELETE record " + eid, "Confirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    query = "DELETE FROM EmpReg WHERE EmpID = '" + eid + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("record deleted successfully");
                    clear();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while deleting" + Environment.NewLine + err);
                con.Close();
            }
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            // NIC text box user input check
            if (txtNIC.Text.Length == 10 || txtNIC.Text.Length == 12)
            {
                txtNIC.ForeColor = Color.Green;
            }
            else
            {
                txtNIC.ForeColor = Color.Red;

            }
           
        }

        private void txtNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // avoid entering more than 12 characters in NIC textbox
            if (char.IsControl(e.KeyChar)) // allow control keys
            {
                return;
            }
            
            if (txtNIC.Text.Length > 11)
            {
                e.Handled = true;
            }
        }

        private void txtConNo_TextChanged(object sender, EventArgs e)
        {
            // checks user's contact number lenght
            if (txtConNo.Text.Length == 10)
            {
                txtConNo.ForeColor = Color.Green;
            }
            else
            {
                txtConNo.ForeColor = Color.Red;

            }
        }

        private void txtConNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // limit user input to 10 characters
            if (char.IsControl(e.KeyChar)) // gets backspace and other control key inputs
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
            if (txtConNo.Text.Length > 9)
            {
                e.Handled = true;
            }
        }

        private void txtMonthlySalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // gets only digits in monthy salary textbox
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }

        }

        private void txtOTHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // gets only numbers in hourly rate text box
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-digit input
                return;
            }
        }

        private void txtAllowances_KeyPress(object sender, KeyPressEventArgs e)
        {
            // gets only numbers on allowances text box
            if (char.IsControl(e.KeyChar))
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
            // reset all user inputs
            SerialNoGenerator();
            txtName.Text = "";
            txtNIC.Text = "";
            txtConNo.Text = "";
            txtDOB.Text = "";
            txtAddress.Text = "";
            txtMonthlySalary.Text = "";
            txtOTHourlyRate.Text = "";
            txtAllowances.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbMarried.Checked = false;
            rbUnmarried.Checked = false;
            txtName.Focus();
            btnSearch.Visible = true;
            cmbEmpID.Visible = false;
            lblEmpID.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnClear.Text = "Clear";

        }

        private void btnSave_Click(object sender, EventArgs e) // save button
        {
            // check for missing inputs
            if (rbFemale.Checked == false && rbMale.Checked == false) 
            {
                MessageBox.Show("Please select Gender");
            }else if (rbMarried.Checked == false && rbUnmarried.Checked == false)
            {
                MessageBox.Show("Please select Civil Status");
            }
            else
            {
                // save to database
                try
                {
                    if (rbMale.Checked == true)
                    {
                        gen = "Male";
                    }
                    else if (rbFemale.Checked == true)
                    {
                        gen = "Female";
                    }
                    if (rbMarried.Checked == true)
                    {
                        stat = "Married";
                    }
                    else if (rbUnmarried.Checked == true)
                    {
                        stat = "Unmarried";
                    }

                    query = "INSERT INTO empReg(SerialNo,EmpID,Name,NIC,ConNo,DOB,EmpAddress,Gender,CivilStatus,MonSalary,OTHRate,Allowance) VALUES('" + serialNo + "','" + eid + "','" + txtName.Text + "','" + txtNIC.Text + "','" + txtConNo.Text + "','" + txtDOB.Text + "','" + txtAddress.Text + "','" + gen + "','" + stat + "','" + txtMonthlySalary.Text + "','" + txtOTHourlyRate.Text + "','" + txtAllowances.Text + "');";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee ID: " + eid + " successfully SAVED to the database!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();


                }
                catch (Exception err)
                {
                    MessageBox.Show("Error while Saving" + Environment.NewLine + err);
                    con.Close();
                }
            }

               
        }

        private void EmpRegForm_Load(object sender, EventArgs e)
        {
            SerialNoGenerator(); // generate serial number
        }
    }
}
