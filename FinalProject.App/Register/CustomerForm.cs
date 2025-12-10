

using FinalProject.App.Base;
using FinalProject.Domain.Base;
using FinalProject.App.ViewModel;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;

namespace FinalProject.App.Register
{
    public partial class CustomerForm : BaseForm
    {

        #region Variables
        private IBaseService<Address> _addressService;
        private IBaseService<Customer> _customerService;
        private List<CustomerViewModel>? customers;
        #endregion

        #region Constructor
        public CustomerForm(IBaseService<Customer> customerService, IBaseService<Address> addressService)
        {
            _customerService = customerService;
            _addressService = addressService;
            InitializeComponent();
            LoadCombo();
        }
        #endregion

        #region Methods
        private void FormToObject(Customer customer)
        {
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Password = txtPassword.Text;
            if (int.TryParse(txtCityState.SelectedValue!.ToString(), out var idAddress))
            {
                var address = _addressService.GetById<Address>(idAddress);
                customer.Address = address;
            }
        }

        private void LoadCombo()
        {
            txtCityState.ValueMember = "Id";
            txtCityState.DisplayMember = "CityState";
            txtCityState.DataSource = _addressService.Get<AddressViewModel>().ToList();
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var customer = _customerService.GetById<Customer>(id);
                    FormToObject(customer);
                    customer = _customerService.Update<Customer, Customer, CustomerValidator>(customer);
                }
                else
                {
                    var customer = new Customer();
                    FormToObject(customer);
                    customer = _customerService.Add<Customer, Customer, CustomerValidator>(customer);
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
                _customerService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string> { "Address" };
            customers = _customerService.Get<CustomerViewModel>(includes).ToList();
            dataGridViewBaseForm.DataSource = customers;
            dataGridViewBaseForm.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Email"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Password"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Password"].Visible = false;
            dataGridViewBaseForm.Columns["IdAddress"].Visible = false;
            dataGridViewBaseForm.Columns["CityState"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["CityState"].HeaderText = "City State";
            dataGridViewBaseForm.Columns["RegisterDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["RegisterDate"].HeaderText = "Register Date";
            dataGridViewBaseForm.Columns["RegisterDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtCityState.SelectedValue = record?.Cells["IdAddress"].Value;
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtEmail.Text = record.Cells["Email"].Value.ToString();
            txtPassword.Text = record.Cells["Password"].Value.ToString();
            record.Cells["RegisterDate"].Value.ToString();
        }
        #endregion 

        #region Events
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
            txtName.Focus();
        }
        #endregion 

    }
}
