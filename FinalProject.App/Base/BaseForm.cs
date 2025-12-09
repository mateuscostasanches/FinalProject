    using ReaLTaiizor.Controls;
    using ReaLTaiizor.Forms;

    namespace FinalProject.App.Base
    {
        public partial class BaseForm : LostForm
        {
            #region Variables
            protected bool IsEditMode = false;
            #endregion

            #region Constructor Method
            public BaseForm()
            {
                InitializeComponent();
        }
            #endregion

            #region Events
            private void btnCancel_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Are you sure you want cancel?", @"Final Project",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearFields();
                    TabControl.SelectedIndex = 1;
            }
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                Save();
            }

            private void btnNew_Click(object sender, EventArgs e)
            {
                New();
            }

            private void btnEdit_Click(object sender, EventArgs e)
            {
                Edit();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (dataGridViewBaseForm.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want delete?", @"Final Project",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var id = (int)dataGridViewBaseForm.SelectedRows[0].Cells["id"].Value;
                        Delete(id);
                        PopulateGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Please, select any row!", @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void tabPage2_Enter(object sender, EventArgs e)
            {
                PopulateGrid();
            }
            #endregion

            #region Methods
            protected void ClearFields()
            {
                IsEditMode = false;
                foreach (var control in RegisterTabPage.Controls)
                {
                    if (control is MaterialTextBoxEdit textBox)
                    {
                        textBox.Clear();
                    }
                    if (control is MaterialMaskedTextBox maskedTextBox)
                    {
                        maskedTextBox.Clear();
                    }
                }
            }

            protected virtual void Save()
            {

            }

            protected virtual void Edit()
            {
                if (dataGridViewBaseForm.SelectedRows.Count > 0)
                {
                    IsEditMode = true;
                    var record = dataGridViewBaseForm.SelectedRows[0];
                    GridToForm(record);
                    TabControl.SelectedIndex = 0;
                    RegisterTabPage.Focus();
                }
                else
                {
                    MessageBox.Show("Please, select any row!", @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            protected virtual void New()
            {
                ClearFields();
                TabControl.SelectedIndex = 0;
                RegisterTabPage.Focus();
            }

            protected virtual void Delete(int id)
            {

            }

            protected virtual void GridToForm(DataGridViewRow? record)
            {

            }

            protected virtual void PopulateGrid()
            {

            }
            #endregion

        }

    }
