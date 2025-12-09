namespace FinalProject.App.Register
{
    partial class ProductForm
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
            txtDescription = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCategory = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDeveloper = new ReaLTaiizor.Controls.MaterialComboBox();
            txtReleaseDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            RegisterTabPage.Controls.Add(txtReleaseDate);
            RegisterTabPage.Controls.Add(txtDeveloper);
            RegisterTabPage.Controls.Add(txtCategory);
            RegisterTabPage.Controls.Add(txtPrice);
            RegisterTabPage.Controls.Add(txtId);
            RegisterTabPage.Controls.Add(txtDescription);
            RegisterTabPage.Controls.Add(txtName);
            RegisterTabPage.Size = new Size(788, 372);
            RegisterTabPage.Controls.SetChildIndex(txtName, 0);
            RegisterTabPage.Controls.SetChildIndex(lostPanel1, 0);
            RegisterTabPage.Controls.SetChildIndex(txtDescription, 0);
            RegisterTabPage.Controls.SetChildIndex(txtId, 0);
            RegisterTabPage.Controls.SetChildIndex(txtPrice, 0);
            RegisterTabPage.Controls.SetChildIndex(txtCategory, 0);
            RegisterTabPage.Controls.SetChildIndex(txtDeveloper, 0);
            RegisterTabPage.Controls.SetChildIndex(txtReleaseDate, 0);
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
            txtName.Font = new Font("Symbol", 15.75F);
            txtName.HidePromptOnLeave = false;
            txtName.HideSelection = true;
            txtName.Hint = "Game";
            txtName.InsertKeyMode = InsertKeyMode.Default;
            txtName.LeadingIcon = null;
            txtName.Location = new Point(26, 62);
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
            txtName.Size = new Size(448, 48);
            txtName.SkipLiterals = true;
            txtName.TabIndex = 23;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            txtName.ValidatingType = null;
            // 
            // txtDescription
            // 
            txtDescription.AllowPromptAsInput = true;
            txtDescription.AnimateReadOnly = false;
            txtDescription.AsciiOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.BeepOnError = false;
            txtDescription.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Symbol", 15.75F);
            txtDescription.HidePromptOnLeave = false;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Description";
            txtDescription.InsertKeyMode = InsertKeyMode.Default;
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(26, 127);
            txtDescription.Mask = "";
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.PrefixSuffixText = null;
            txtDescription.PromptChar = '_';
            txtDescription.ReadOnly = false;
            txtDescription.RejectInputOnFirstFailure = false;
            txtDescription.ResetOnPrompt = true;
            txtDescription.ResetOnSpace = true;
            txtDescription.RightToLeft = RightToLeft.No;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(448, 48);
            txtDescription.SkipLiterals = true;
            txtDescription.TabIndex = 24;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDescription.TrailingIcon = null;
            txtDescription.UseSystemPasswordChar = false;
            txtDescription.ValidatingType = null;
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
            txtId.Location = new Point(255, 197);
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
            txtId.Size = new Size(219, 48);
            txtId.SkipLiterals = true;
            txtId.TabIndex = 25;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.ValidatingType = null;
            // 
            // txtPrice
            // 
            txtPrice.AllowPromptAsInput = true;
            txtPrice.AnimateReadOnly = false;
            txtPrice.AsciiOnly = false;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.BeepOnError = false;
            txtPrice.Cursor = Cursors.IBeam;
            txtPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.Depth = 0;
            txtPrice.Font = new Font("Symbol", 15.75F);
            txtPrice.HidePromptOnLeave = false;
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.InsertKeyMode = InsertKeyMode.Default;
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(26, 197);
            txtPrice.Mask = "000.00";
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.PromptChar = '0';
            txtPrice.ReadOnly = false;
            txtPrice.RejectInputOnFirstFailure = false;
            txtPrice.ResetOnPrompt = true;
            txtPrice.ResetOnSpace = true;
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(223, 48);
            txtPrice.SkipLiterals = true;
            txtPrice.TabIndex = 26;
            txtPrice.TabStop = false;
            txtPrice.Text = "000,00";
            txtPrice.TextAlign = HorizontalAlignment.Right;
            txtPrice.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.ValidatingType = null;
            // 
            // txtCategory
            // 
            txtCategory.AutoResize = false;
            txtCategory.BackColor = Color.FromArgb(255, 255, 255);
            txtCategory.Depth = 0;
            txtCategory.DrawMode = DrawMode.OwnerDrawVariable;
            txtCategory.DropDownHeight = 174;
            txtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategory.DropDownWidth = 121;
            txtCategory.Font = new Font("Symbol", 15.75F);
            txtCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCategory.FormattingEnabled = true;
            txtCategory.Hint = "Category";
            txtCategory.IntegralHeight = false;
            txtCategory.ItemHeight = 43;
            txtCategory.Location = new Point(480, 127);
            txtCategory.MaxDropDownItems = 4;
            txtCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(284, 49);
            txtCategory.StartIndex = 0;
            txtCategory.TabIndex = 27;
            // 
            // txtDeveloper
            // 
            txtDeveloper.AutoResize = false;
            txtDeveloper.BackColor = Color.FromArgb(255, 255, 255);
            txtDeveloper.Depth = 0;
            txtDeveloper.DrawMode = DrawMode.OwnerDrawVariable;
            txtDeveloper.DropDownHeight = 174;
            txtDeveloper.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDeveloper.DropDownWidth = 121;
            txtDeveloper.Font = new Font("Symbol", 15.75F);
            txtDeveloper.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDeveloper.FormattingEnabled = true;
            txtDeveloper.Hint = "Developer";
            txtDeveloper.IntegralHeight = false;
            txtDeveloper.ItemHeight = 43;
            txtDeveloper.Location = new Point(480, 61);
            txtDeveloper.MaxDropDownItems = 4;
            txtDeveloper.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDeveloper.Name = "txtDeveloper";
            txtDeveloper.Size = new Size(284, 49);
            txtDeveloper.StartIndex = 0;
            txtDeveloper.TabIndex = 28;
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.AllowPromptAsInput = true;
            txtReleaseDate.AnimateReadOnly = false;
            txtReleaseDate.AsciiOnly = false;
            txtReleaseDate.BackgroundImageLayout = ImageLayout.None;
            txtReleaseDate.BeepOnError = false;
            txtReleaseDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtReleaseDate.Depth = 0;
            txtReleaseDate.Enabled = false;
            txtReleaseDate.Font = new Font("Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtReleaseDate.HidePromptOnLeave = false;
            txtReleaseDate.HideSelection = true;
            txtReleaseDate.Hint = "Release Date";
            txtReleaseDate.InsertKeyMode = InsertKeyMode.Default;
            txtReleaseDate.LeadingIcon = null;
            txtReleaseDate.Location = new Point(480, 197);
            txtReleaseDate.Mask = "__/__/____";
            txtReleaseDate.MaxLength = 32767;
            txtReleaseDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.PasswordChar = '\0';
            txtReleaseDate.PrefixSuffixText = null;
            txtReleaseDate.PromptChar = '_';
            txtReleaseDate.ReadOnly = false;
            txtReleaseDate.RejectInputOnFirstFailure = false;
            txtReleaseDate.ResetOnPrompt = true;
            txtReleaseDate.ResetOnSpace = true;
            txtReleaseDate.RightToLeft = RightToLeft.No;
            txtReleaseDate.SelectedText = "";
            txtReleaseDate.SelectionLength = 0;
            txtReleaseDate.SelectionStart = 0;
            txtReleaseDate.ShortcutsEnabled = true;
            txtReleaseDate.Size = new Size(284, 48);
            txtReleaseDate.SkipLiterals = true;
            txtReleaseDate.TabIndex = 29;
            txtReleaseDate.TabStop = false;
            txtReleaseDate.Text = "__/__/____";
            txtReleaseDate.TextAlign = HorizontalAlignment.Left;
            txtReleaseDate.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtReleaseDate.TrailingIcon = null;
            txtReleaseDate.UseSystemPasswordChar = false;
            txtReleaseDate.ValidatingType = null;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductForm";
            Text = "Games";
            TitleColor = Color.Gray;
            TopMost = true;
            Load += ProductForm_Load;
            TabControl.ResumeLayout(false);
            RegisterTabPage.ResumeLayout(false);
            ListTabPage.ResumeLayout(false);
            lostPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox txtDeveloper;
        private ReaLTaiizor.Controls.MaterialComboBox txtCategory;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrice;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDescription;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPublicationDate;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtReleaseDate;
    }
}