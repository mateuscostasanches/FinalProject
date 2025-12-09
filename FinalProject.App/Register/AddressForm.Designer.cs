namespace FinalProject.App.Register
{
    partial class AddressForm
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
            txtId = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCity = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtState = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            RegisterTabPage.Controls.Add(txtState);
            RegisterTabPage.Controls.Add(txtCity);
            RegisterTabPage.Controls.Add(txtId);
            RegisterTabPage.ImeMode = ImeMode.Off;
            RegisterTabPage.Size = new Size(788, 372);
            RegisterTabPage.Controls.SetChildIndex(txtId, 0);
            RegisterTabPage.Controls.SetChildIndex(txtCity, 0);
            RegisterTabPage.Controls.SetChildIndex(txtState, 0);
            RegisterTabPage.Controls.SetChildIndex(lostPanel1, 0);
            // 
            // lostPanel1
            // 
            lostPanel1.Location = new Point(3, 314);
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
            txtId.Location = new Point(240, 201);
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
            txtId.Size = new Size(276, 48);
            txtId.SkipLiterals = true;
            txtId.TabIndex = 20;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.ValidatingType = null;
            // 
            // txtCity
            // 
            txtCity.AllowPromptAsInput = true;
            txtCity.AnimateReadOnly = false;
            txtCity.AsciiOnly = false;
            txtCity.BackgroundImageLayout = ImageLayout.None;
            txtCity.BeepOnError = false;
            txtCity.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCity.Depth = 0;
            txtCity.Font = new Font("Symbol", 15.75F);
            txtCity.HidePromptOnLeave = false;
            txtCity.HideSelection = true;
            txtCity.Hint = "City";
            txtCity.InsertKeyMode = InsertKeyMode.Default;
            txtCity.LeadingIcon = null;
            txtCity.Location = new Point(240, 93);
            txtCity.Mask = "";
            txtCity.MaxLength = 32767;
            txtCity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.PrefixSuffixText = null;
            txtCity.PromptChar = '_';
            txtCity.ReadOnly = false;
            txtCity.RejectInputOnFirstFailure = false;
            txtCity.ResetOnPrompt = true;
            txtCity.ResetOnSpace = true;
            txtCity.RightToLeft = RightToLeft.No;
            txtCity.SelectedText = "";
            txtCity.SelectionLength = 0;
            txtCity.SelectionStart = 0;
            txtCity.ShortcutsEnabled = true;
            txtCity.Size = new Size(276, 48);
            txtCity.SkipLiterals = true;
            txtCity.TabIndex = 21;
            txtCity.TabStop = false;
            txtCity.TextAlign = HorizontalAlignment.Left;
            txtCity.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCity.TrailingIcon = null;
            txtCity.UseSystemPasswordChar = false;
            txtCity.ValidatingType = null;
            // 
            // txtState
            // 
            txtState.AllowPromptAsInput = true;
            txtState.AnimateReadOnly = false;
            txtState.AsciiOnly = false;
            txtState.BackgroundImageLayout = ImageLayout.None;
            txtState.BeepOnError = false;
            txtState.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtState.Depth = 0;
            txtState.Font = new Font("Symbol", 15.75F);
            txtState.HidePromptOnLeave = false;
            txtState.HideSelection = true;
            txtState.Hint = "State";
            txtState.InsertKeyMode = InsertKeyMode.Default;
            txtState.LeadingIcon = null;
            txtState.Location = new Point(240, 147);
            txtState.Mask = "";
            txtState.MaxLength = 32767;
            txtState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtState.Name = "txtState";
            txtState.PasswordChar = '\0';
            txtState.PrefixSuffixText = null;
            txtState.PromptChar = '_';
            txtState.ReadOnly = false;
            txtState.RejectInputOnFirstFailure = false;
            txtState.ResetOnPrompt = true;
            txtState.ResetOnSpace = true;
            txtState.RightToLeft = RightToLeft.No;
            txtState.SelectedText = "";
            txtState.SelectionLength = 0;
            txtState.SelectionStart = 0;
            txtState.ShortcutsEnabled = true;
            txtState.Size = new Size(276, 48);
            txtState.SkipLiterals = true;
            txtState.TabIndex = 23;
            txtState.TabStop = false;
            txtState.TextAlign = HorizontalAlignment.Left;
            txtState.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtState.TrailingIcon = null;
            txtState.UseSystemPasswordChar = false;
            txtState.ValidatingType = null;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddressForm";
            Text = "Addresses";
            TitleColor = Color.Gray;
            TopMost = true;
            TabControl.ResumeLayout(false);
            RegisterTabPage.ResumeLayout(false);
            ListTabPage.ResumeLayout(false);
            lostPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCity;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtState;
    }
}