
using FinalProject.App.Base;
using FinalProject.Domain.Base;
using FinalProject.App.ViewModel;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;

namespace FinalProject.App.Register
{
    public partial class AddressForm : BaseForm
    {

        #region Variables
        private IBaseService<Address> _addressService;
        private List<AddressViewModel>? addresses;
        #endregion

        #region Constructor
        public AddressForm(IBaseService<Address> addressService)
        {
            _addressService = addressService;
            InitializeComponent();

        }
        #endregion

        #region Methods
        private void FormToObject(Address address)
        {
            address.State = txtState.Text;
            address.City = txtCity.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var address = _addressService.GetById<Address>(id);
                    FormToObject(address);
                    address = _addressService.Update<Address, Address, AddressValidator>(address);
                }
                else
                {
                    var address = new Address();
                    FormToObject(address);
                    address = _addressService.Add<Address, Address, AddressValidator>(address);
                }
                TabControl.SelectedIndex = 1;
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
                _addressService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            addresses = _addressService.Get<AddressViewModel>().ToList();
            dataGridViewBaseForm.DataSource = addresses;
            dataGridViewBaseForm.Columns["State"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["City"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["CityState"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtState.Text = record?.Cells["State"].Value.ToString();
            txtCity.Text = record?.Cells["City"].Value.ToString();
        }
        #endregion

        #region Events
        private void AddressForm_Load(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
            txtCity.Focus();
        }
        #endregion 

    }

}

