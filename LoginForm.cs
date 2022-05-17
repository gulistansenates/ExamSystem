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
        SqlConnection cmd = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
           /* con.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '"+txtUsername.Text+"' and password = '"+txtPassword.Text+"'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();*/
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
