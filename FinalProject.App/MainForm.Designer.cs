namespace FinalProject.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenu = new ReaLTaiizor.Controls.CrownMenuStrip();
            registerToolStripMenuItem1 = new ToolStripMenuItem();
            newAddressToolStripMenuItem = new ToolStripMenuItem();
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            newUserToolStripMenuItem = new ToolStripMenuItem();
            newDeveloperToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            newSaleToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem2 = new ToolStripMenuItem();
            closeToolStripMenuItem2 = new ToolStripMenuItem();
            pbMainForm = new PictureBox();
            MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainForm).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackColor = Color.FromArgb(63, 63, 70);
            MainMenu.ForeColor = Color.FromArgb(220, 220, 220);
            MainMenu.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem1, reportToolStripMenuItem1, helpToolStripMenuItem2, closeToolStripMenuItem2 });
            MainMenu.Location = new Point(2, 30);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(3, 2, 0, 2);
            MainMenu.Size = new Size(1276, 24);
            MainMenu.TabIndex = 1;
            MainMenu.Text = "crownMenuStrip1";
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            registerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newAddressToolStripMenuItem, newCategoryToolStripMenuItem, newUserToolStripMenuItem, newDeveloperToolStripMenuItem, helpToolStripMenuItem1, newSaleToolStripMenuItem });
            registerToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(61, 20);
            registerToolStripMenuItem1.Text = "Register";
            // 
            // newAddressToolStripMenuItem
            // 
            newAddressToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            newAddressToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            newAddressToolStripMenuItem.Name = "newAddressToolStripMenuItem";
            newAddressToolStripMenuItem.Size = new Size(163, 22);
            newAddressToolStripMenuItem.Text = "New Address...";
            newAddressToolStripMenuItem.Click += newAddressToolStripMenuItem_Click;
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            newCategoryToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(163, 22);
            newCategoryToolStripMenuItem.Text = "New Category...";
            newCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
            // 
            // newUserToolStripMenuItem
            // 
            newUserToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            newUserToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            newUserToolStripMenuItem.Size = new Size(163, 22);
            newUserToolStripMenuItem.Text = "New Customer...";
            newUserToolStripMenuItem.Click += newCustomerToolStripMenuItem_Click;
            // 
            // newDeveloperToolStripMenuItem
            // 
            newDeveloperToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            newDeveloperToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            newDeveloperToolStripMenuItem.Name = "newDeveloperToolStripMenuItem";
            newDeveloperToolStripMenuItem.Size = new Size(163, 22);
            newDeveloperToolStripMenuItem.Text = "New Developer...";
            newDeveloperToolStripMenuItem.Click += newDeveloperToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            helpToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(163, 22);
            helpToolStripMenuItem1.Text = "New Game...";
            helpToolStripMenuItem1.Click += newGameToolStripMenuItem1_Click;
            // 
            // newSaleToolStripMenuItem
            // 
            newSaleToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            newSaleToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            newSaleToolStripMenuItem.Name = "newSaleToolStripMenuItem";
            newSaleToolStripMenuItem.Size = new Size(163, 22);
            newSaleToolStripMenuItem.Text = "New Sale...";
            newSaleToolStripMenuItem.Click += newSaleToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem1
            // 
            reportToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            reportToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            reportToolStripMenuItem1.Size = new Size(54, 20);
            reportToolStripMenuItem1.Text = "Report";
            // 
            // helpToolStripMenuItem2
            // 
            helpToolStripMenuItem2.BackColor = Color.FromArgb(60, 63, 65);
            helpToolStripMenuItem2.ForeColor = Color.FromArgb(220, 220, 220);
            helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            helpToolStripMenuItem2.Size = new Size(44, 20);
            helpToolStripMenuItem2.Text = "Help";
            // 
            // closeToolStripMenuItem2
            // 
            closeToolStripMenuItem2.BackColor = Color.FromArgb(60, 63, 65);
            closeToolStripMenuItem2.ForeColor = Color.FromArgb(220, 220, 220);
            closeToolStripMenuItem2.Name = "closeToolStripMenuItem2";
            closeToolStripMenuItem2.Size = new Size(48, 20);
            closeToolStripMenuItem2.Text = "Close";
            // 
            // pbMainForm
            // 
            pbMainForm.Dock = DockStyle.Fill;
            pbMainForm.Image = Properties.Resources.Project_Logo_png;
            pbMainForm.Location = new Point(2, 54);
            pbMainForm.Name = "pbMainForm";
            pbMainForm.Size = new Size(1276, 664);
            pbMainForm.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMainForm.TabIndex = 2;
            pbMainForm.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            BackgroundImageLayout = ImageLayout.Center;
            BorderColor = Color.Transparent;
            BorderStyle = ButtonBorderStyle.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(pbMainForm);
            Controls.Add(MainMenu);
            Font = new Font("Yu Gothic UI", 12F);
            HeaderColor = Color.FromArgb(60, 63, 65);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.app_icon;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Padding = new Padding(2, 30, 2, 2);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "stream - version 1.0.2025";
            TitleColor = Color.Gray;
            WindowState = FormWindowState.Maximized;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownMenuStrip MainMenu;
        private ToolStripMenuItem registerToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem newCategoryToolStripMenuItem;
        private ToolStripMenuItem newDeveloperToolStripMenuItem;
        private ToolStripMenuItem newUserToolStripMenuItem;
        private ToolStripMenuItem newAddressToolStripMenuItem;
        private ToolStripMenuItem newSaleToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem2;
        private ToolStripMenuItem closeToolStripMenuItem2;
        private PictureBox pbMainForm;
    }
}
