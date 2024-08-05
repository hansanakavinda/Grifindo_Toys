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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter adap = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=BADASS;Initial Catalog=GrifindoToys;Integrated Security=True");

        public static string name, type;
        string query;

        private void clear()
        {
            // reset inputs 
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
            eyeOpen.Visible = false;
            eyeClose.Visible = true;
            txtPassword.PasswordChar = '*';
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void eyeClose_Click(object sender, EventArgs e)
        {
            // show the password
            eyeClose.Visible = false;
            eyeOpen.Visible = true;
            txtPassword.PasswordChar = default;

        }

        private void eyeOpen_Click(object sender, EventArgs e)
        {
            // hide the password
            eyeClose.Visible = true;
            eyeOpen.Visible = false;
            txtPassword.PasswordChar = '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear text fields
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to EXIT?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (DialogResult.Yes == result)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // checks username and password form the database
            try
            {
                query = "SELECT * FROM userReg WHERE username= '" + txtUsername.Text + "' AND password= '" + txtPassword.Text + "'";
                con.Open();
                adap = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adap.Fill(table);

                if (table.Rows.Count > 0)
                {
                    // gets realname and type of the user   
                    query = "SELECT * FROM userReg WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                    cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        name = reader.GetValue(0).ToString();
                        type =  reader.GetValue(3).ToString();
                    }

                    Form next = new mainForm();
                    this.Hide();
                    next.Show();
                    clear();

                    
                }
                else
                {
                    MessageBox.Show("Check your login details", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clear();
                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while Login" + Environment.NewLine + err);
                con.Close();
            }
        }
    }
}
