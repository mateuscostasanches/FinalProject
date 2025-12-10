namespace FinalProject.App.Register
{
    partial class CategoryForm
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
            txtName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            TabControl.SuspendLayout();
            RegisterTabPage.SuspendLayout();
            ListTabPage.SuspendLayout();
            lostPanel.SuspendLayout();
            lostPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.BackgroundColor = Color.FromArgb(63, 63, 70);
            TabControl.Size = new Size(796, 418);
            // 
            // RegisterTabPage
            // 
            RegisterTabPage.Controls.Add(txtId);
            RegisterTabPage.Controls.Add(txtName);
            RegisterTabPage.Size = new Size(788, 372);
            RegisterTabPage.Controls.SetChildIndex(lostPanel1, 0);
            RegisterTabPage.Controls.SetChildIndex(txtName, 0);
            RegisterTabPage.Controls.SetChildIndex(txtId, 0);
            // 
            // lostPanel1
            // 
            lostPanel1.Location = new Point(3, 314);
            // 
            // txtName
            // 
            txtName.AllowPromptAsInput = true;
            txtName.AnimateReadOnly = false;
            txtName.AsciiOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.BeepOnError = false;
            txtName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtName.Depth = 0;
            txtName.Font = new Font("Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtName.HidePromptOnLeave = false;
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.InsertKeyMode = InsertKeyMode.Default;
            txtName.LeadingIcon = null;
            txtName.Location = new Point(205, 125);
            txtName.Mask = "";
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.PromptChar = '_';
            txtName.ReadOnly = false;
            txtName.RejectInputOnFirstFailure = false;
            txtName.ResetOnPrompt = true;
            txtName.ResetOnSpace = true;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(341, 48);
            txtName.SkipLiterals = true;
            txtName.TabIndex = 12;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            txtName.ValidatingType = null;
            // 
            // txtId
            // 
            txtId.AllowPromptAsInput = true;
            txtId.AnimateReadOnly = false;
            txtId.AsciiOnly = false;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.BeepOnError = false;
            txtId.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Symbol", 15.75F);
            txtId.HidePromptOnLeave = false;
            txtId.HideSelection = true;
            txtId.InsertKeyMode = InsertKeyMode.Default;
            txtId.LeadingIcon = Properties.Resources.id_icon;
            txtId.Location = new Point(205, 179);
            txtId.Mask = "";
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.PromptChar = '_';
            txtId.ReadOnly = false;
            txtId.RejectInputOnFirstFailure = false;
            txtId.ResetOnPrompt = true;
            txtId.ResetOnSpace = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(341, 48);
            txtId.SkipLiterals = true;
            txtId.TabIndex = 13;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.ValidatingType = null;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryForm";
            Text = "Categories";
            TitleColor = Color.Gray;
            TopMost = true;
            Load += CategoryForm_Load;
            TabControl.ResumeLayout(false);
            RegisterTabPage.ResumeLayout(false);
            ListTabPage.ResumeLayout(false);
            lostPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtName;
    }
}