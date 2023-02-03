using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EmployeeManagement
{
    public partial class PublisherPortal : Form
    {
        public PublisherPortal()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnAssignTask.BackColor = System.Drawing.Color.RosyBrown;

            btnAddEmp.BackColor = System.Drawing.Color.RosyBrown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnAssignTask.BackColor = System.Drawing.Color.Transparent;

            btnAddEmp.BackColor = System.Drawing.Color.RosyBrown;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            btnAssignTask.BackColor = System.Drawing.Color.RosyBrown;

            btnAddEmp.BackColor = System.Drawing.Color.RosyBrown;

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            btnAddEmp.BackColor = System.Drawing.Color.Transparent;

            btnAssignTask.BackColor= System.Drawing.Color.RosyBrown;

            btnAddEmp.Location = new System.Drawing.Point(274,35);

            btnAddEmp.Size = new System.Drawing.Size(103, 30);

            btnAssignTask.Visible = false;

            picAdd.Visible = false;

            picAssign.Visible= false;

            pnEmp.Visible = true;

            lblHome.Visible = false;

            picHome.Visible = false;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


        private void btnClose2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbPassword2_Click(object sender, EventArgs e)
        {

        }

        private void lbDesignation_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnEmp.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            pnAddEmp.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbGender_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string number = txtContactNo.Text;
            if ((number.Length == 11) && (number.StartsWith("01")))
            {
                pbRight1.Visible = true;
                pbWrong1.Visible = false;
            }
            else
            {
                pbWrong1.Visible = true;
                pbRight1.Visible = false;
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            txtFullName.Text = txtFirstName + "  " + txtLastName;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Contains("@") && email.EndsWith(".com"))
            {
                pbRight2.Visible = true;
                pbWrong2.Visible = false;
            }
            else
            {
                pbWrong2.Visible = true;
                pbRight2.Visible = false;
            }
        }

        private void lbDesignation_Click_1(object sender, EventArgs e)
        {

        }

        private void lbSSC_Click(object sender, EventArgs e)
        {

        }

        private void pbWrong2_Click(object sender, EventArgs e)
        {

        }

        private void txtSSC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDegree_Click(object sender, EventArgs e)
        {

        }

        private void lbGPA_Click(object sender, EventArgs e)
        {

        }

        private void txtDegree_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDiploma_Click(object sender, EventArgs e)
        {

        }

        private void cbPassingYearDiploma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPassingYearSSC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiploma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMasters_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMasters_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnDeleteEmp.Visible = true;
        }

        private void pnDeleteEmp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbEmpID_Click(object sender, EventArgs e)
        {

        }
    }
}
