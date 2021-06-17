using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login_and_registration_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter db = new OleDbDataAdapter();



        private void dashboard_Load(object sender, EventArgs e)
        {
            //Conection:
            con.Open();

            //Execute the command:
            string fetch = "SELECT * FROM tbl_users WHERE Email = '"+LoginInfo.email+"' ";
            
            cmd = new OleDbCommand(fetch, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string names = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                email.Text = reader["Email"].ToString();
                designation.Text = reader["Designation"].ToString();
                contact.Text = reader["Contact"].ToString();
                gender.Text = reader["Gender"].ToString();
                address.Text = reader["Address"].ToString();
                dob.Text = reader["dob"].ToString();
                username.Text = reader["FirstName"].ToString();
                name.Text = names;
            }
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void dob_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
