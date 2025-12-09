namespace FinalProject.App.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            TabControl = new ReaLTaiizor.Controls.MetroTabControl();
            RegisterTabPage = new TabPage();
            lostPanel1 = new ReaLTaiizor.Controls.LostPanel();
            btnCancel = new ReaLTaiizor.Controls.LostCancelButton();
            btnSave = new ReaLTaiizor.Controls.LostAcceptButton();
            ListTabPage = new TabPage();
            lostPanel = new ReaLTaiizor.Controls.LostPanel();
            btnDelete = new ReaLTaiizor.Controls.LostCancelButton();
            btnNew = new ReaLTaiizor.Controls.LostAcceptButton();
            btnEdit = new ReaLTaiizor.Controls.LostButton();
            dataGridViewBaseForm = new DataGridView();
            TabControl.SuspendLayout();
            RegisterTabPage.SuspendLayout();
            lostPanel1.SuspendLayout();
            ListTabPage.SuspendLayout();
            lostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaseForm).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.None;
            TabControl.AnimateTime = 0;
            TabControl.BackgroundColor = Color.White;
            TabControl.Controls.Add(RegisterTabPage);
            TabControl.Controls.Add(ListTabPage);
            TabControl.ControlsVisible = true;
            TabControl.Dock = DockStyle.Fill;
            TabControl.IsDerivedStyle = true;
            TabControl.ItemSize = new Size(100, 38);
            TabControl.Location = new Point(2, 30);
            TabControl.MCursor = Cursors.Hand;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.SelectedTextColor = Color.FromArgb(65, 177, 225);
            TabControl.Size = new Size(796, 468);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.Speed = 100;
            TabControl.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabControl.StyleManager = null;
            TabControl.TabIndex = 0;
            TabControl.TabStyle = ReaLTaiizor.Enum.Metro.TabStyle.Style2;
            TabControl.ThemeAuthor = "Taiizor";
            TabControl.ThemeName = "MetroLight";
            TabControl.UnselectedTextColor = Color.Gray;
            // 
            // RegisterTabPage
            // 
            RegisterTabPage.BackColor = Color.White;
            RegisterTabPage.Controls.Add(lostPanel1);
            RegisterTabPage.Location = new Point(4, 42);
            RegisterTabPage.Name = "RegisterTabPage";
            RegisterTabPage.Padding = new Padding(3);
            RegisterTabPage.Size = new Size(788, 422);
            RegisterTabPage.TabIndex = 0;
            RegisterTabPage.Text = "Register";
            // 
            // lostPanel1
            // 
            lostPanel1.BackColor = Color.White;
            lostPanel1.Controls.Add(btnCancel);
            lostPanel1.Controls.Add(btnSave);
            lostPanel1.Dock = DockStyle.Bottom;
            lostPanel1.Font = new Font("Segoe UI", 12F);
            lostPanel1.ForeColor = Color.White;
            lostPanel1.Location = new Point(3, 364);
            lostPanel1.Name = "lostPanel1";
            lostPanel1.Padding = new Padding(5);
            lostPanel1.ShowText = true;
            lostPanel1.Size = new Size(782, 55);
            lostPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverColor = Color.Empty;
            btnCancel.Image = null;
            btnCancel.Location = new Point(526, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.HoverColor = Color.Empty;
            btnSave.Image = null;
            btnSave.Location = new Point(652, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // ListTabPage
            // 
            ListTabPage.BackColor = Color.FromArgb(45, 45, 48);
            ListTabPage.Controls.Add(lostPanel);
            ListTabPage.Controls.Add(dataGridViewBaseForm);
            ListTabPage.Location = new Point(4, 42);
            ListTabPage.Name = "ListTabPage";
            ListTabPage.Padding = new Padding(3);
            ListTabPage.Size = new Size(788, 422);
            ListTabPage.TabIndex = 1;
            ListTabPage.Text = "List";
            ListTabPage.Enter += tabPage2_Enter;
            // 
            // lostPanel
            // 
            lostPanel.BackColor = Color.White;
            lostPanel.Controls.Add(btnDelete);
            lostPanel.Controls.Add(btnNew);
            lostPanel.Controls.Add(btnEdit);
            lostPanel.Dock = DockStyle.Bottom;
            lostPanel.Font = new Font("Segoe UI", 12F);
            lostPanel.ForeColor = Color.White;
            lostPanel.Location = new Point(3, 364);
            lostPanel.Name = "lostPanel";
            lostPanel.Padding = new Padding(5);
            lostPanel.ShowText = true;
            lostPanel.Size = new Size(782, 55);
            lostPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverColor = Color.IndianRed;
            btnDelete.Image = null;
            btnDelete.Location = new Point(400, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.DodgerBlue;
            btnNew.Font = new Font("Segoe UI", 9F);
            btnNew.ForeColor = Color.White;
            btnNew.HoverColor = Color.SteelBlue;
            btnNew.Image = null;
            btnNew.Location = new Point(652, 8);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(120, 40);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(45, 45, 48);
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverColor = Color.Empty;
            btnEdit.Image = null;
            btnEdit.Location = new Point(526, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridViewBaseForm
            // 
            dataGridViewBaseForm.AllowUserToAddRows = false;
            dataGridViewBaseForm.AllowUserToDeleteRows = false;
            dataGridViewBaseForm.AllowUserToResizeColumns = false;
            dataGridViewBaseForm.AllowUserToResizeRows = false;
            dataGridViewBaseForm.BackgroundColor = Color.White;
            dataGridViewBaseForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaseForm.Dock = DockStyle.Fill;
            dataGridViewBaseForm.GridColor = Color.FromArgb(63, 63, 70);
            dataGridViewBaseForm.ImeMode = ImeMode.Off;
            dataGridViewBaseForm.Location = new Point(3, 3);
            dataGridViewBaseForm.Name = "dataGridViewBaseForm";
            dataGridViewBaseForm.ReadOnly = true;
            dataGridViewBaseForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBaseForm.Size = new Size(782, 416);
            dataGridViewBaseForm.TabIndex = 1;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.Transparent;
            ClientSize = new Size(800, 500);
            Controls.Add(TabControl);
            Font = new Font("Yu Gothic UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = null;
            Name = "BaseForm";
            Padding = new Padding(2, 30, 2, 2);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Base Form";
            TabControl.ResumeLayout(false);
            RegisterTabPage.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            ListTabPage.ResumeLayout(false);
            lostPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaseForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected ReaLTaiizor.Controls.MetroTabControl TabControl;
        protected TabPage RegisterTabPage;
        protected TabPage ListTabPage;
        protected ReaLTaiizor.Controls.LostPanel lostPanel;
        protected ReaLTaiizor.Controls.LostPanel lostPanel1;
        protected ReaLTaiizor.Controls.LostButton btnEdit;
        protected ReaLTaiizor.Controls.LostAcceptButton btnNew;
        protected ReaLTaiizor.Controls.LostAcceptButton btnSave;
        protected ReaLTaiizor.Controls.LostCancelButton btnDelete;
        protected ReaLTaiizor.Controls.LostCancelButton btnCancel;
        protected DataGridView dataGridViewBaseForm;
    }
}