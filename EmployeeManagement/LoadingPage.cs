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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadingProgress.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingProgress.Value += 3;
            if (LoadingProgress.Value == 100)
            {

                timer1.Enabled = false;
                this.Hide();
                Login login = new Login();
                login.Show();

            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
