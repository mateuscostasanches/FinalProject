
using FinalProject.App.Base;
using FinalProject.App.ViewModel;
using FinalProject.Domain.Base;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;
using System.Globalization;

namespace FinalProject.App.Register
{
    public partial class DeveloperForm : BaseForm
    {

        #region Variables
        private IBaseService<Address> _addressService;
        private IBaseService<Developer> _developerService;
        private List<DeveloperViewModel>? developers;
        public static bool loginUser;
        #endregion

        #region Constructor
        public DeveloperForm(IBaseService<Developer> developerService, IBaseService<Address> addressService)
        {
            _developerService = developerService;
            _addressService = addressService;
            InitializeComponent();
            LoadCombo();
        }
        #endregion

        #region Methods
        private void FormToObject(Developer developer)
        {
            developer.Name = txtName.Text;
            developer.Email = txtEmail.Text;
            developer.Password = txtPassword.Text;
            developer.RegisterDate = DateTime.Now;

            if (int.TryParse(txtCityState.SelectedValue!.ToString(), out var idAddress))
            {
                var address = _addressService.GetById<Address>(idAddress);
                developer.Address = address;
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
                    var developer = _developerService.GetById<Developer>(id);
                    FormToObject(developer);
                    developer = _developerService.Update<Developer, Developer, DeveloperValidator>(developer);
                }
                else
                {
                    var developer = new Developer();
                    FormToObject(developer);
                    developer = _developerService.Add<Developer, Developer, DeveloperValidator>(developer);

                    if (loginUser)
                    {
                        MainForm.developer = developer;
                        loginUser = false;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
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
                _developerService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Final Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {

            var includes = new List<string> { "Address" };
            developers = _developerService.Get<DeveloperViewModel>(includes).ToList();
            dataGridViewBaseForm.DataSource = developers;
            dataGridViewBaseForm.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Email"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Password"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["Password"]!.Visible = false;
            dataGridViewBaseForm.Columns["IdAddress"]!.Visible = false;
            dataGridViewBaseForm.Columns["CityState"].HeaderText = "City State";
            dataGridViewBaseForm.Columns["CityState"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["RegisterDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBaseForm.Columns["RegisterDate"].HeaderText = "Register Date";
            dataGridViewBaseForm.Columns["RegisterDate"].DefaultCellStyle.Format = "MM/dd/yyyy h:mm:ss tt";
            dataGridViewBaseForm.Columns["RegisterDate"].DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {

            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtEmail.Text = record.Cells["Email"].Value.ToString();
            txtPassword.Text = record.Cells["Password"].Value.ToString();
            txtCityState.SelectedValue = record.Cells["IdAddress"].Value;
            record.Cells["RegisterDate"].Value.ToString();
        }
        #endregion

        #region Events
        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
            LoadCombo();
            txtCityState.SelectedIndex = -1;
        }

         private void txtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.TrailingIcon = Properties.Resources.hidden;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPassword.TrailingIcon = Properties.Resources.eye;
            }
        }
        #endregion

    }

}
