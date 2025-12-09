
using FinalProject.App.Base;
using FinalProject.App.ViewModel;
using FinalProject.Domain.Base;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;
using System.Globalization;

namespace FinalProject.App.Register
{
    public partial class ProductForm : BaseForm
    {
        #region Variables
        private IBaseService<Product> _productService;
        private IBaseService<Category> _categoryService;
        private IBaseService<Developer> _developerService;
        private List<ProductViewModel>? products;
        #endregion

        #region Constructor
        public ProductForm(IBaseService<Product> productService, IBaseService<Category> categoryService,
                           IBaseService<Developer> developerService)
        {
            _developerService = developerService;
            _productService = productService;
            _categoryService = categoryService;

            InitializeComponent();
            LoadCombo();
        }
        #endregion

        #region Methods
        private void LoadCombo()
        {
            txtCategory.ValueMember = "Id";
            txtCategory.DisplayMember = "Name";
            txtCategory.DataSource = _categoryService.Get<CategoryViewModel>().ToList();

            txtDeveloper.ValueMember = "Id";
            txtDeveloper.DisplayMember = "Name";
            txtDeveloper.DataSource = _developerService.Get<DeveloperViewModel>().ToList();
        }

        private void FormToObject(Product product)
        {
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.ReleaseDate = DateTime.Now;

            if (int.TryParse(txtCategory.SelectedValue!.ToString(), out var idCategory))
            {
                var category = _categoryService.GetById<Category>(idCategory);
                product.Category = category;
            }

            if (int.TryParse(txtDeveloper.SelectedValue!.ToString(), out var idDeveloper))
            {
                var developer = _developerService.GetById<Developer>(idDeveloper);
                product.Developer = developer;
            }

            if (decimal.TryParse(txtPrice.Text!.ToString(), out var price))
            {
                product.Price = price;
            }

        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var product = _productService.GetById<Product>(id);
                    FormToObject(product);
                    product = _productService.Update<Product, Product, ProductValidator>(product);
                }
                else
                {
                    var product = new Product();
                    FormToObject(product);
                    product = _productService.Add<Product, Product, ProductValidator>(product);
                }
                TabControl.SelectedIndex = 1;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void Delete(int id)
        {
            try
            {
                _productService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string> { "Category", "Developer" };
            products = _productService.Get<ProductViewModel>(includes).ToList();
            dataGridViewBaseForm.DataSource = products;
            dataGridViewBaseForm.Columns["DeveloperId"].Visible = false;
            dataGridViewBaseForm.Columns["CategoryId"].Visible = false;
            dataGridViewBaseForm.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["ReleaseDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["ReleaseDate"].HeaderText = "Release Date";
            dataGridViewBaseForm.Columns["ReleaseDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridViewBaseForm.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridViewBaseForm.Columns["Price"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dataGridViewBaseForm.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Developer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        protected override void GridToForm(DataGridViewRow? record)
        {

            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtDescription.Text = record.Cells["Description"].Value.ToString();
            txtReleaseDate.Text = record.Cells["ReleaseDate"].Value.ToString();
            txtPrice.Text = record.Cells["Price"].Value.ToString();
            txtCategory.SelectedValue = record.Cells["CategoryId"].Value;
            txtDeveloper.SelectedValue = record.Cells["DeveloperId"].Value;
        }
        #endregion

        #region Events
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        #endregion 
    }

}
