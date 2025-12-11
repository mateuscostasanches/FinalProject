using FinalProject.Domain.Entities;

namespace FinalProject.App.Register
{
    partial class CustomerForm
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
            txtCityState = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            RegisterTabPage.Controls.Add(txtCityState);
            RegisterTabPage.Controls.Add(txtPassword);
            RegisterTabPage.Controls.Add(txtEmail);
            RegisterTabPage.Controls.Add(txtId);
            RegisterTabPage.Controls.Add(txtName);
            RegisterTabPage.Size = new Size(788, 372);
            RegisterTabPage.Controls.SetChildIndex(lostPanel1, 0);
            RegisterTabPage.Controls.SetChildIndex(txtName, 0);
            RegisterTabPage.Controls.SetChildIndex(txtId, 0);
            RegisterTabPage.Controls.SetChildIndex(txtEmail, 0);
            RegisterTabPage.Controls.SetChildIndex(txtPassword, 0);
            RegisterTabPage.Controls.SetChildIndex(txtCityState, 0);
            // 
            // lostPanel1
            // 
            lostPanel1.Location = new Point(3, 314);
            // 
            // txtCityState
            // 
            txtCityState.AutoResize = false;
            txtCityState.BackColor = Color.FromArgb(255, 255, 255);
            txtCityState.Depth = 0;
            txtCityState.DrawMode = DrawMode.OwnerDrawVariable;
            txtCityState.DropDownHeight = 174;
            txtCityState.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCityState.DropDownWidth = 121;
            txtCityState.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCityState.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCityState.FormattingEnabled = true;
            txtCityState.Hint = "City - State";
            txtCityState.IntegralHeight = false;
            txtCityState.ItemHeight = 43;
            txtCityState.Location = new Point(477, 158);
            txtCityState.MaxDropDownItems = 4;
            txtCityState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCityState.Name = "txtCityState";
            txtCityState.Size = new Size(247, 49);
            txtCityState.StartIndex = 0;
            txtCityState.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = Properties.Resources.password_icon;
            txtPassword.Location = new Point(61, 213);
            txtPassword.Mask = "";
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PrefixSuffixText = null;
            txtPassword.PromptChar = '_';
            txtPassword.ReadOnly = false;
            txtPassword.RejectInputOnFirstFailure = false;
            txtPassword.ResetOnPrompt = true;
            txtPassword.ResetOnSpace = true;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(663, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 24;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludePrompt;
            txtPassword.TrailingIcon = Properties.Resources.eye;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ValidatingType = null;
            txtPassword.TrailingIconClick += txtPassword_TrailingIconClick;
            // 
            // txtEmail
            // 
            txtEmail.AllowPromptAsInput = true;
            txtEmail.AnimateReadOnly = false;
            txtEmail.AsciiOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.BeepOnError = false;
            txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtEmail.HidePromptOnLeave = false;
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.InsertKeyMode = InsertKeyMode.Default;
            txtEmail.LeadingIcon = Properties.Resources.email_icon;
            txtEmail.Location = new Point(61, 158);
            txtEmail.Mask = "";
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.PromptChar = '_';
            txtEmail.ReadOnly = false;
            txtEmail.RejectInputOnFirstFailure = false;
            txtEmail.ResetOnPrompt = true;
            txtEmail.ResetOnSpace = true;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(410, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 23;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
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
            txtId.Location = new Point(531, 103);
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
            txtId.Size = new Size(193, 48);
            txtId.SkipLiterals = true;
            txtId.TabIndex = 22;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.ValidatingType = null;
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
            txtName.Location = new Point(61, 103);
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
            txtName.Size = new Size(464, 48);
            txtName.SkipLiterals = true;
            txtName.TabIndex = 21;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            txtName.ValidatingType = null;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerForm";
            Text = "Customers";
            TitleColor = Color.Gray;
            TopMost = true;
            Load += CustomerForm_Load;
            TabControl.ResumeLayout(false);
            RegisterTabPage.ResumeLayout(false);
            ListTabPage.ResumeLayout(false);
            lostPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox txtCityState;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtName;
    }
}