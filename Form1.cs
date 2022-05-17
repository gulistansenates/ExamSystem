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

namespace ExamLoginandRegisterSystem
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OA42U4M\\SQLEXPRESS;Initial Catalog=ExamSystem;Integrated Security=True");
        SqlConnection cmd = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "") ;
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtComPassword.Text) 
             {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES (' " + txtUsername.Text + " ' , ' " + txtPassword.Text + " ');
                cmd = new SqlConnection(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account has been Successfully Created ", "Registration Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            else
            {
                MessageBox.Show("Passwords doesnt match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }
    }
}
