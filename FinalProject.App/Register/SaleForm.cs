
using FinalProject.App.Base;
using FinalProject.App.ViewModel;
using FinalProject.Domain.Base;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;
using System.Globalization;

namespace FinalProject.App.Register
{
    public partial class SaleForm : BaseForm
    {

        #region Variables
        private List<SaleItemViewModel> _saleItems;
        private readonly IBaseService<Developer> _developerService;
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Sale> _saleService;
        private List<SaleViewModel> sales;
        #endregion 

        #region Constructor
        public SaleForm(IBaseService<Sale> saleService, IBaseService<Developer> developerService,
                        IBaseService<Customer> customerService, IBaseService<Product> productService)
        {
            _saleService = saleService;
            _developerService = developerService;
            _customerService = customerService;
            _productService = productService;
            _saleItems = new List<SaleItemViewModel>();
            InitializeComponent();
            LoadCombo();
            PopulateGridItemsSale();
        }
        #endregion 

        #region Methods
        private void LoadCombo()
        {
            txtDeveloper.ValueMember = "Id";
            txtDeveloper.DisplayMember = "Name";
            txtDeveloper.DataSource = _developerService.Get<Developer>().ToList();

            txtCustomer.ValueMember = "Id";
            txtCustomer.DisplayMember = "Name";
            txtCustomer.DataSource = _customerService.Get<Customer>().ToList();

            txtProduct.ValueMember = "Id";
            txtProduct.DisplayMember = "Name";
            txtProduct.DataSource = _productService.Get<Product>().ToList();
        }

        private void FormToObject(Sale sale)
        {
            sale.SaleDate = DateTime.Now.Date;

            if (int.TryParse(txtCustomer.SelectedValue!.ToString(), out var idCustomer))
            {
                var customer = _customerService.GetById<Customer>(idCustomer);
                sale.Customer = customer;
            }

            sale.TotalSale = _saleItems.Sum(x => x.TotalPrice);

            foreach (var item in _saleItems)
            {
                var itemSale = new SaleItem
                {
                    Sale = sale,
                    Product = _productService.GetById<Product>(item.ProductId),
                    Developer = _developerService.GetById<Developer>(item.DeveloperId),
                    UnitPrice = item.UnitPrice,
                };
                sale.SaleItems.Add(itemSale);
            }
        }

        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            PopulateGridItemsSale();
            txtSaleDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var sale = _saleService.GetById<Sale>(id);
                        FormToObject(sale);
                        sale = _saleService.Update<Sale, Sale, SaleValidator>(sale);
                    }
                }
                else
                {
                    var sale = new Sale();

                    if (sale.SaleItems == null)
                    {
                        sale.SaleItems = new List<SaleItem>();
                    }

                    FormToObject(sale);
                    sale = _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }
                TabControl.SelectedIndex = 1;
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
                _saleService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string>() { "Customer" };
            sales = _saleService.Get<SaleViewModel>(includes).ToList();
            dataGridViewBaseForm.DataSource = sales;
            dataGridViewBaseForm.Columns["CustomerId"]!.Visible = false;
            dataGridViewBaseForm.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Customer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["SaleDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["TotalSale"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["SaleDate"].HeaderText = "Sale Date";
            dataGridViewBaseForm.Columns["TotalSale"].HeaderText = "Total Sale";
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            int.TryParse(record?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtCustomer.SelectedValue = record?.Cells["CustomerId"].Value;
            txtSaleDate.Text = record?.Cells["SaleDate"].Value.ToString();

            var includes = new List<string>() { "Customer", "SaleItems", "SaleItems.Product", "SaleItems.Developer" };
            var sale = _saleService.GetById<Sale>(id, includes);

            if (sale.SaleItems == null)
            {
                sale.SaleItems = new List<SaleItem>();
            }

            _saleItems = new List<SaleItemViewModel>();
            foreach (var item in sale.SaleItems)
            {
                var saleItem = new SaleItemViewModel
                {
                    Id = item.Id,
                    ProductId = item.Product!.Id,
                    Product = item.Product!.Name,
                    UnitPrice = item.UnitPrice,
                    DeveloperId = item.Developer!.Id,
                    Developer = item.Developer!.Name,
                };
                _saleItems.Add(saleItem);
            }
            PopulateGridItemsSale();
        }

        private void PopulateGridItemsSale()
        {
            var source = new BindingSource();
            source.DataSource = _saleItems.ToArray();
            DataGridViewSaleItems.DataSource = source;
            DataGridViewSaleItems.Columns["Id"]!.Visible = false;
            DataGridViewSaleItems.Columns["ProductId"].HeaderText = "Product Id";
            DataGridViewSaleItems.Columns["ProductId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewSaleItems.Columns["DeveloperId"].Visible = false;
            DataGridViewSaleItems.Columns["Developer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewSaleItems.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewSaleItems.Columns["UnitPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewSaleItems.Columns["UnitPrice"].HeaderText = "Unity Price";
            DataGridViewSaleItems.Columns["TotalPrice"].Visible = false;

        }

        private bool ItemValidation()
        {
            return true;
        }

        private void CalculateTotalSale()
        {
            decimal totalSaleValue = _saleItems.Sum(x => x.TotalPrice);
            txtTotalPrice.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", totalSaleValue);

            int totalQuantity = _saleItems.Count;
            txtQuantity.Text = totalQuantity.ToString();
        }
        #endregion

        #region Events
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (ItemValidation())
            {
                var saleItem = new SaleItemViewModel();

                if (int.TryParse(txtProduct.SelectedValue.ToString(), out var idProduct))
                {
                    var product = _productService.GetById<Product>(idProduct);
                    saleItem.ProductId = product.Id;
                    saleItem.Product = product.Name;
                }

                if (decimal.TryParse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var UnitValue))
                {
                    saleItem.UnitPrice = UnitValue;
                }

                if (txtDeveloper.SelectedValue != null && int.TryParse(txtDeveloper.SelectedValue.ToString(), out var idDeveloper))
                {
                    saleItem.DeveloperId = idDeveloper;
                    var developer = _developerService.GetById<Developer>(idDeveloper);
                    if (developer != null)
                    {
                        saleItem.Developer = developer.Name;
                    }

                    saleItem.TotalPrice = saleItem.UnitPrice;
                    _saleItems.Add(saleItem);
                    CalculateTotalSale();
                    PopulateGridItemsSale();
                }
            }
        }

        private void btnRemoveGame_Click(object sender, EventArgs e)
        {
            if (DataGridViewSaleItems.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridViewSaleItems.SelectedRows[0];
                if (int.TryParse(selectedRow.Cells["ProductId"].Value?.ToString(), out var idProductToRemove))
                {
                    var itemToRemove = _saleItems.FirstOrDefault(item => item.ProductId == idProductToRemove);

                    if (itemToRemove != null)
                    {
                        _saleItems.Remove(itemToRemove);
                        CalculateTotalSale();
                        PopulateGridItemsSale();
                    }
                }
                else
                {
                    MessageBox.Show("Could not identify the selected product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a game in the table to remove.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtProduct.SelectedValue != null && int.TryParse(txtProduct.SelectedValue.ToString(), out int idProduct))
            {
                var product = _productService.GetById<Product>(idProduct);

                if (product != null)
                {
                    txtUnitPrice.Text = string.Format(CultureInfo.CurrentCulture, "{0:N2}", product.Price);

                    if (string.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out _))
                    {
                        txtQuantity.Text = "1";
                    }

                }
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        #endregion

    }
}