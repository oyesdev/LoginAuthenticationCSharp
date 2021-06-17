using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login_and_registration_system
{

    public static class LoginInfo
    {
        public static string email;
    }

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter db = new OleDbDataAdapter();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE Email = '"+textEmail.Text+"' and Password = '"+textPassword.Text+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                LoginInfo.email = textEmail.Text;
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password! ");
                textEmail.Text = "";
                textPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEmail.Text = "";
            textPassword.Text = "";
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
