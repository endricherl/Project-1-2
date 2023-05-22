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

namespace Project_1
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-UVHM62P\SQLEXPRESS;Initial Catalog=userpass;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != string.Empty || txtuser.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from [dbo].[Register] where username='" + txtuser.Text + "' and password='" + txtpass.Text + "'", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Login Successful.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rdr.Close();
                    this.Hide();
                    new Form3().Show();
                    this.Hide();
                }
                else
                {
                    rdr.Close();
                    MessageBox.Show("There is no account available with this username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}