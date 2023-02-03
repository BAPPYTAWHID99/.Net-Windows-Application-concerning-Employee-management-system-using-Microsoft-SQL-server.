namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbEmp = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.LoadingProgress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LoadingProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEmp.Location = new System.Drawing.Point(110, 26);
            this.lbEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(280, 26);
            this.lbEmp.TabIndex = 0;
            this.lbEmp.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.lbEmp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTxt.Location = new System.Drawing.Point(164, 225);
            this.lblTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(167, 16);
            this.lblTxt.TabIndex = 1;
            this.lblTxt.Text = "DevelopedBy@BappyTawhid";
            this.lblTxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoadingProgress
            // 
            this.LoadingProgress.AnimationSpeed = 0.6F;
            this.LoadingProgress.BaseColor = System.Drawing.Color.White;
            this.LoadingProgress.Controls.Add(this.gunaCirclePictureBox1);
            this.LoadingProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.LoadingProgress.IdleOffset = 0;
            this.LoadingProgress.IdleThickness = 10;
            this.LoadingProgress.Image = null;
            this.LoadingProgress.ImageSize = new System.Drawing.Size(52, 52);
            this.LoadingProgress.Location = new System.Drawing.Point(164, 55);
            this.LoadingProgress.Name = "LoadingProgress";
            this.LoadingProgress.ProgressMaxColor = System.Drawing.Color.Red;
            this.LoadingProgress.ProgressMinColor = System.Drawing.Color.Maroon;
            this.LoadingProgress.ProgressOffset = 0;
            this.LoadingProgress.ProgressThickness = 10;
            this.LoadingProgress.Size = new System.Drawing.Size(167, 160);
            this.LoadingProgress.TabIndex = 2;
            this.LoadingProgress.Click += new System.EventHandler(this.LoadingProgress_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(34, 30);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(95, 99);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.LoadingProgress);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.lbEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoadingProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Label lblTxt;
        private Guna.UI.WinForms.GunaCircleProgressBar LoadingProgress;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

