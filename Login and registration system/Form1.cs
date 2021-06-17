using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login_and_registration_system
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter db = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string designation = txtCompDesig.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 10;
            string phone = textBox3.Text;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textComPassword_TextChanged(object sender, EventArgs e)
        {
            textComPassword.PasswordChar = '*';
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
        }

        private void txtDob_TextChanged(object sender, EventArgs e)
        {
            string dateOfBirth = txtDob.Text;
        }

        private void txtCompEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtCompEmail.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string address = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fName = txtFirstName.Text;
            var lName = txtLastName.Text;
            var dob = txtDob.Text;
            var email = txtCompEmail.Text;
            var password = textComPassword.Text;
            var designation = txtCompDesig.Text;
            var contact = textBox3.Text;
            var gender = "";
            var address = textBox4.Text;

            if (fName == "" && lName == "" && dob == "" && email == "" && password == "" && designation == "" && contact == "" && gender == "" && address == "")
            {
                MessageBox.Show("Fields cannot be empty");
            }

            else 
            {
                foreach (Control control in this.Controls)
                {

                    if (control.GetType() == typeof(TextBox))
                    {

                        control.Text = "";

                    }

                }

                if (radioButton1.Checked)
                {
                    gender = radioButton1.Text;
                }

                if (radioButton2.Checked)
                {
                    gender = radioButton2.Text;
                }

                con.Open();
                string register = "INSERT INTO tbl_users VALUES('"+fName+"', '"+lName+"', '"+dob+"', '"+email+"', '"+password+"', '"+designation+"', '"+contact+"', '"+gender+"', '"+address+"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Successfull");
            }

        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                textComPassword.PasswordChar = '\0';
            }
            else
            {
                textComPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";

                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
