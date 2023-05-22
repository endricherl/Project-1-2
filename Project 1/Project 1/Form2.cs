using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_1
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader rdr;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtconfirm.Text != string.Empty || txtsetpass.Text != string.Empty || txtsetuser.Text != string.Empty)
            {
                if (txtsetpass.Text == txtconfirm.Text)
                {
                    cmd = new SqlCommand("select * from [dbo].[Register] where username='" + txtsetuser.Text + "'", cn);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        rdr.Close();
                        cmd = new SqlCommand("insert into [dbo].[Register] values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtsetuser.Text);
                        cmd.Parameters.AddWithValue("password", txtsetpass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have created an account.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsetuser.Clear();
                    txtsetpass.Clear();
                    txtconfirm.Clear();
                    txtsetuser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsetuser.Clear();
                txtsetpass.Clear();
                txtconfirm.Clear();
                txtsetuser.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsetuser.Clear();
            txtsetpass.Clear();
            txtconfirm.Clear();
            txtsetuser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-UVHM62P\SQLEXPRESS;Initial Catalog=userpass;Integrated Security=True");
            cn.Open();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtsetpass.PasswordChar = '\0';
                txtconfirm.PasswordChar = '\0';

            }
            else
            {
                txtsetpass.PasswordChar = '*';
                txtconfirm.PasswordChar = '*';
            }
        }
    }
}
