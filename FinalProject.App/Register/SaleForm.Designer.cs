namespace FinalProject.App.Register
{
    partial class SaleForm
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
            txtDeveloper = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCustomer = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox1 = new GroupBox();
            lostButton1 = new ReaLTaiizor.Controls.LostButton();
            txtQuantity = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            DataGridViewSaleItems = new DataGridView();
            txtTotalPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnRemoveGame = new ReaLTaiizor.Controls.LostButton();
            txtUnitPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            label1 = new Label();
            TabControl.SuspendLayout();
            RegisterTabPage.SuspendLayout();
            ListTabPage.SuspendLayout();
            lostPanel.SuspendLayout();
            lostPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSaleItems).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.BackgroundColor = Color.FromArgb(63, 63, 70);
            TabControl.Size = new Size(796, 568);
            // 
            // RegisterTabPage
            // 
            RegisterTabPage.Controls.Add(txtId);
            RegisterTabPage.Controls.Add(groupBox1);
            RegisterTabPage.Controls.Add(txtCustomer);
            RegisterTabPage.Controls.Add(txtDeveloper);
            RegisterTabPage.Controls.Add(txtProduct);
            RegisterTabPage.Size = new Size(788, 522);
            RegisterTabPage.Controls.SetChildIndex(txtProduct, 0);
            RegisterTabPage.Controls.SetChildIndex(txtDeveloper, 0);
            RegisterTabPage.Controls.SetChildIndex(txtCustomer, 0);
            RegisterTabPage.Controls.SetChildIndex(groupBox1, 0);
            RegisterTabPage.Controls.SetChildIndex(txtId, 0);
            RegisterTabPage.Controls.SetChildIndex(lostPanel1, 0);
            // 
            // lostPanel1
            // 
            lostPanel1.Controls.Add(label1);
            lostPanel1.Location = new Point(3, 464);
            lostPanel1.Controls.SetChildIndex(btnSave, 0);
            lostPanel1.Controls.SetChildIndex(btnCancel, 0);
            lostPanel1.Controls.SetChildIndex(label1, 0);
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
            txtId.Location = new Point(29, 88);
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
            txtId.Size = new Size(180, 48);
            txtId.SkipLiterals = true;
            txtId.TabIndex = 21;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.ValidatingType = null;
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
            txtDeveloper.Location = new Point(394, 33);
            txtDeveloper.MaxDropDownItems = 4;
            txtDeveloper.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDeveloper.Name = "txtDeveloper";
            txtDeveloper.Size = new Size(361, 49);
            txtDeveloper.StartIndex = 0;
            txtDeveloper.TabIndex = 28;
            // 
            // txtCustomer
            // 
            txtCustomer.AutoResize = false;
            txtCustomer.BackColor = Color.FromArgb(255, 255, 255);
            txtCustomer.Depth = 0;
            txtCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            txtCustomer.DropDownHeight = 174;
            txtCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCustomer.DropDownWidth = 121;
            txtCustomer.Font = new Font("Symbol", 15.75F);
            txtCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCustomer.FormattingEnabled = true;
            txtCustomer.Hint = "Customer";
            txtCustomer.IntegralHeight = false;
            txtCustomer.ItemHeight = 43;
            txtCustomer.Location = new Point(29, 33);
            txtCustomer.MaxDropDownItems = 4;
            txtCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(361, 49);
            txtCustomer.StartIndex = 0;
            txtCustomer.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lostButton1);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(DataGridViewSaleItems);
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Controls.Add(btnRemoveGame);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.ForeColor = Color.Gray;
            groupBox1.Location = new Point(29, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 316);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Games in Cart";
            // 
            // lostButton1
            // 
            lostButton1.BackColor = Color.FromArgb(63, 63, 70);
            lostButton1.Font = new Font("Segoe UI", 9F);
            lostButton1.ForeColor = Color.White;
            lostButton1.HoverColor = Color.FromArgb(45, 45, 48);
            lostButton1.Image = null;
            lostButton1.Location = new Point(583, 28);
            lostButton1.Name = "lostButton1";
            lostButton1.Size = new Size(126, 49);
            lostButton1.TabIndex = 37;
            lostButton1.Text = "+Add Game";
            lostButton1.Click += btnNewGame_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.AllowPromptAsInput = true;
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.AsciiOnly = false;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.BeepOnError = false;
            txtQuantity.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtQuantity.Depth = 0;
            txtQuantity.Enabled = false;
            txtQuantity.Font = new Font("Symbol", 15.75F);
            txtQuantity.HidePromptOnLeave = false;
            txtQuantity.HideSelection = true;
            txtQuantity.InsertKeyMode = InsertKeyMode.Default;
            txtQuantity.LeadingIcon = Properties.Resources.store;
            txtQuantity.Location = new Point(367, 28);
            txtQuantity.Mask = "";
            txtQuantity.MaxLength = 32767;
            txtQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.PromptChar = '_';
            txtQuantity.ReadOnly = false;
            txtQuantity.RejectInputOnFirstFailure = false;
            txtQuantity.ResetOnPrompt = true;
            txtQuantity.ResetOnSpace = true;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(90, 48);
            txtQuantity.SkipLiterals = true;
            txtQuantity.TabIndex = 36;
            txtQuantity.TabStop = false;
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            txtQuantity.ValidatingType = null;
            // 
            // DataGridViewSaleItems
            // 
            DataGridViewSaleItems.AllowUserToAddRows = false;
            DataGridViewSaleItems.AllowUserToDeleteRows = false;
            DataGridViewSaleItems.AllowUserToResizeColumns = false;
            DataGridViewSaleItems.AllowUserToResizeRows = false;
            DataGridViewSaleItems.BackgroundColor = Color.FromArgb(63, 63, 70);
            DataGridViewSaleItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSaleItems.GridColor = Color.FromArgb(45, 45, 48);
            DataGridViewSaleItems.Location = new Point(16, 83);
            DataGridViewSaleItems.Name = "DataGridViewSaleItems";
            DataGridViewSaleItems.ReadOnly = true;
            DataGridViewSaleItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewSaleItems.Size = new Size(693, 214);
            DataGridViewSaleItems.TabIndex = 35;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.AllowPromptAsInput = true;
            txtTotalPrice.AnimateReadOnly = false;
            txtTotalPrice.AsciiOnly = false;
            txtTotalPrice.BackgroundImageLayout = ImageLayout.None;
            txtTotalPrice.BeepOnError = false;
            txtTotalPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalPrice.Depth = 0;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Symbol", 15.75F);
            txtTotalPrice.HidePromptOnLeave = false;
            txtTotalPrice.HideSelection = true;
            txtTotalPrice.Hint = "Total Price";
            txtTotalPrice.InsertKeyMode = InsertKeyMode.Default;
            txtTotalPrice.LeadingIcon = null;
            txtTotalPrice.Location = new Point(186, 28);
            txtTotalPrice.Mask = "";
            txtTotalPrice.MaxLength = 32767;
            txtTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Padding = new Padding(0, 0, 0, 15);
            txtTotalPrice.PasswordChar = '\0';
            txtTotalPrice.PrefixSuffixText = null;
            txtTotalPrice.PromptChar = '_';
            txtTotalPrice.ReadOnly = false;
            txtTotalPrice.RejectInputOnFirstFailure = false;
            txtTotalPrice.ResetOnPrompt = true;
            txtTotalPrice.ResetOnSpace = true;
            txtTotalPrice.RightToLeft = RightToLeft.No;
            txtTotalPrice.SelectedText = "";
            txtTotalPrice.SelectionLength = 0;
            txtTotalPrice.SelectionStart = 0;
            txtTotalPrice.ShortcutsEnabled = true;
            txtTotalPrice.Size = new Size(175, 48);
            txtTotalPrice.SkipLiterals = true;
            txtTotalPrice.TabIndex = 33;
            txtTotalPrice.TabStop = false;
            txtTotalPrice.TextAlign = HorizontalAlignment.Left;
            txtTotalPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalPrice.TrailingIcon = null;
            txtTotalPrice.UseSystemPasswordChar = false;
            txtTotalPrice.ValidatingType = null;
            // 
            // btnRemoveGame
            // 
            btnRemoveGame.BackColor = Color.Crimson;
            btnRemoveGame.Font = new Font("Segoe UI", 9F);
            btnRemoveGame.ForeColor = Color.White;
            btnRemoveGame.HoverColor = Color.DarkRed;
            btnRemoveGame.Image = null;
            btnRemoveGame.Location = new Point(463, 28);
            btnRemoveGame.Name = "btnRemoveGame";
            btnRemoveGame.Size = new Size(114, 49);
            btnRemoveGame.TabIndex = 34;
            btnRemoveGame.Text = "Delete Game";
            btnRemoveGame.Click += btnRemoveGame_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.AllowPromptAsInput = true;
            txtUnitPrice.AnimateReadOnly = false;
            txtUnitPrice.AsciiOnly = false;
            txtUnitPrice.BackgroundImageLayout = ImageLayout.None;
            txtUnitPrice.BeepOnError = false;
            txtUnitPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUnitPrice.Depth = 0;
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("Symbol", 15.75F);
            txtUnitPrice.HidePromptOnLeave = false;
            txtUnitPrice.HideSelection = true;
            txtUnitPrice.Hint = "Unit Price";
            txtUnitPrice.InsertKeyMode = InsertKeyMode.Default;
            txtUnitPrice.LeadingIcon = null;
            txtUnitPrice.Location = new Point(16, 28);
            txtUnitPrice.Mask = "";
            txtUnitPrice.MaxLength = 32767;
            txtUnitPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Padding = new Padding(0, 0, 0, 15);
            txtUnitPrice.PasswordChar = '\0';
            txtUnitPrice.PrefixSuffixText = null;
            txtUnitPrice.PromptChar = '_';
            txtUnitPrice.ReadOnly = false;
            txtUnitPrice.RejectInputOnFirstFailure = false;
            txtUnitPrice.ResetOnPrompt = true;
            txtUnitPrice.ResetOnSpace = true;
            txtUnitPrice.RightToLeft = RightToLeft.No;
            txtUnitPrice.SelectedText = "";
            txtUnitPrice.SelectionLength = 0;
            txtUnitPrice.SelectionStart = 0;
            txtUnitPrice.ShortcutsEnabled = true;
            txtUnitPrice.Size = new Size(164, 48);
            txtUnitPrice.SkipLiterals = true;
            txtUnitPrice.TabIndex = 32;
            txtUnitPrice.TabStop = false;
            txtUnitPrice.TextAlign = HorizontalAlignment.Left;
            txtUnitPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUnitPrice.TrailingIcon = null;
            txtUnitPrice.UseSystemPasswordChar = false;
            txtUnitPrice.ValidatingType = null;
            // 
            // txtProduct
            // 
            txtProduct.AutoResize = false;
            txtProduct.BackColor = Color.FromArgb(255, 255, 255);
            txtProduct.Depth = 0;
            txtProduct.DrawMode = DrawMode.OwnerDrawVariable;
            txtProduct.DropDownHeight = 174;
            txtProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProduct.DropDownWidth = 121;
            txtProduct.Font = new Font("Symbol", 15.75F);
            txtProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtProduct.FormattingEnabled = true;
            txtProduct.Hint = "Game";
            txtProduct.IntegralHeight = false;
            txtProduct.ItemHeight = 43;
            txtProduct.Location = new Point(215, 88);
            txtProduct.MaxDropDownItems = 4;
            txtProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(540, 49);
            txtProduct.StartIndex = 0;
            txtProduct.TabIndex = 31;
            txtProduct.SelectedIndexChanged += txtProduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 36;
            label1.Text = "label1";
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaleForm";
            Text = "Sales";
            TitleColor = Color.Gray;
            Load += SaleForm_Load;
            TabControl.ResumeLayout(false);
            RegisterTabPage.ResumeLayout(false);
            ListTabPage.ResumeLayout(false);
            lostPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            lostPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewSaleItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtId;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialComboBox txtCustomer;
        private ReaLTaiizor.Controls.MaterialComboBox txtDeveloper;
        private ReaLTaiizor.Controls.MaterialComboBox txtProduct;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTotalPrice;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtUnitPrice;
        private ReaLTaiizor.Controls.LostButton btnRemoveGame;
        private DataGridView DataGridViewSaleItems;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtQuantity;
        private ReaLTaiizor.Controls.LostButton lostButton1;
    }
}