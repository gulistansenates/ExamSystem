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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OA42U4M\\SQLEXPRESS;Initial Catalog=ExamSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '"+txtUsername.Text+"' and password = '"+txtPassword.Text+"'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()== true)
            {
                MessageBox.Show("sucess ", "Login success", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again ", "Login Failed", MessageBoxButtons.OK);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void CheckbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
           }
        }
    }
