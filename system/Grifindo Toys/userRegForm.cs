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
    public partial class userRegForm : Form
    {
        public userRegForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=BADASS;Initial Catalog=GrifindoToys;Integrated Security=True");


        private void btnExit_Click(object sender, EventArgs e)
        {
            // move to main form
            DialogResult result = MessageBox.Show("Are you sure you want to EXIT?", "Conform to Exti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void clear()
        {
            // reset text box values
            txtname.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbUsertype.SelectedIndex = 0;
            lblUsernameStatus.Text = "";
            txtname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            // save button
            try
            {
                // checks for empty or missed inputs
                if (txtPassword.Text == "" || txtUsername.Text == "" || txtname.Text == "")
                {
                    MessageBox.Show("All fields must be filled", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
                else if (cmbUsertype.SelectedIndex == 0)
                {
                    MessageBox.Show("please select the user type", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbUsertype.Focus();
                }else
                {
                    // save data to database
                    string query = "INSERT INTO userReg(name, username, password, type) VALUES('" + txtname.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbUsertype.SelectedItem.ToString() + "')";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User " + txtname.Text + " successfully added ", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while saving" + Environment.NewLine + err);

            }
            
            
        }

        private void userRegForm_Load(object sender, EventArgs e)
        {
            clear(); 
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // checks the availability of username
            try
            {
                string query = "SELECT * FROM userReg WHERE username = '" + txtUsername.Text + "'";
                con.Open();
                adap = new SqlDataAdapter(query, con);
                DataTable tab = new DataTable();
                adap.Fill(tab);

                if (tab.Rows.Count > 0)
                {
                    txtUsername.ForeColor = Color.Red;
                    btnSave.Enabled = false;
                    lblUsernameStatus.Text = "Username Unavailable";
                    lblUsernameStatus.ForeColor = Color.Red;
                }
                else
                {
                    txtUsername.ForeColor = Color.Green;
                    btnSave.Enabled = true;
                    lblUsernameStatus.Text = "Username Available";
                    lblUsernameStatus.ForeColor = Color.Turquoise;

                }
                if (txtUsername.Text == "")
                {
                    lblUsernameStatus.Text = "";
                }
                con.Close();
            }catch (Exception err)
            {
                MessageBox.Show("Error while fetching" + Environment.NewLine + err);

            }

        }
    }
}
