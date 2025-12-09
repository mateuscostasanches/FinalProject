

using FinalProject.App.Base;
using FinalProject.App.ViewModel;
using FinalProject.Domain.Base;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;

namespace FinalProject.App.Register
{
    public partial class CategoryForm : BaseForm
    {

        #region Variables
        private IBaseService<Category> _categoryService;
        private List<CategoryViewModel>? categories;
        #endregion 

        #region Constructor
        public CategoryForm(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
            }
        }
        #endregion 

        #region Methods
        private void FormToObject(Category category)
        {
            category.Name = txtName.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var category = _categoryService.GetById<Category>(id);
                    FormToObject(category);
                    category = _categoryService.Update<Category, Category, CategoryValidator>(category);
                }
                else
                {
                    var category = new Category();
                    FormToObject(category);
                    category = _categoryService.Add<Category, Category, CategoryValidator>(category);
                }
                TabControl.SelectedIndex = 1;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        protected override void Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            categories = _categoryService.Get<CategoryViewModel>().ToList();
            dataGridViewBaseForm.DataSource = categories;
            dataGridViewBaseForm.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
        }
        #endregion
    }

}
