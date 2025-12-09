namespace FinalProject.App.Others
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogin = new ReaLTaiizor.Controls.TextBoxEdit();
            lblLogin = new ReaLTaiizor.Controls.LostLabel();
            lblPassword = new ReaLTaiizor.Controls.LostLabel();
            txtPassword = new ReaLTaiizor.Controls.TextBoxEdit();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            lblTitle = new ReaLTaiizor.Controls.BigLabel();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Transparent;
            txtLogin.Font = new Font("Tahoma", 11F);
            txtLogin.ForeColor = Color.FromArgb(176, 183, 191);
            txtLogin.Image = Properties.Resources.customer_icon;
            txtLogin.Location = new Point(106, 205);
            txtLogin.MaxLength = 32767;
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.ReadOnly = false;
            txtLogin.Size = new Size(369, 41);
            txtLogin.TabIndex = 0;
            txtLogin.TextAlignment = HorizontalAlignment.Left;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.FromArgb(45, 45, 48);
            lblLogin.Font = new Font("Segoe UI", 14F);
            lblLogin.ForeColor = Color.Gray;
            lblLogin.Location = new Point(106, 175);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(57, 29);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login:";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.FromArgb(45, 45, 48);
            lblPassword.Font = new Font("Segoe UI", 14F);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(106, 257);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Tahoma", 11F);
            txtPassword.ForeColor = Color.FromArgb(176, 183, 191);
            txtPassword.Image = Properties.Resources.password_icon;
            txtPassword.Location = new Point(106, 286);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(369, 41);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlignment = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackgroundImage = Properties.Resources.Project_Logo_png;
            parrotPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            parrotPictureBox1.ColorLeft = Color.Empty;
            parrotPictureBox1.ColorRight = Color.Empty;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.Image = null;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = true;
            parrotPictureBox1.Location = new Point(165, 106);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(60, 60);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 4;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(221, 106);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 59);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "stream";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(106, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(369, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.Transparent;
            ClientSize = new Size(600, 480);
            Controls.Add(btnLogin);
            Controls.Add(parrotPictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.app_icon;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "stream - version 1.0.2025";
            TitleColor = Color.Gray;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.TextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.LostLabel lblLogin;
        private ReaLTaiizor.Controls.LostLabel lblPassword;
        private ReaLTaiizor.Controls.TextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private ReaLTaiizor.Controls.BigLabel lblTitle;
        protected ReaLTaiizor.Controls.LostCancelButton btnCancel;
        private Button btnLogin;
    }
}