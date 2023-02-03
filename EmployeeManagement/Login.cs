using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Publisher" && txtPassword.Text == "admin")
            {
                this.Hide();
                PublisherPortal home = new PublisherPortal();
                home.Show();
            }
            else
            {
                lblAcess.Enabled = true;
                lblAcess.Text = "Incorrect Username OR Password.";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";

            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                lblAcess.Text = "";
            }

        }

        private void lblAcess_Click(object sender, EventArgs e)
        {

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
