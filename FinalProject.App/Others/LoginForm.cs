

using ReaLTaiizor.Forms;
using FinalProject.Domain.Base;
using FinalProject.Domain.Entities;
using FinalProject.Service.Validators;

namespace FinalProject.App.Others
{
    public partial class LoginForm : LostForm
    {
        #region Variables
        private readonly IBaseService<Developer> _developerService;
        private readonly IBaseService<Address> _addressService;
        #endregion

        #region Constructor
        public LoginForm(IBaseService<Developer> developerService, IBaseService<Address> addressService)
        {
            InitializeComponent();
            _developerService = developerService;
            _addressService = addressService;
        }
        #endregion

        #region Methods
        private Developer? GetDeveloper(string login, string password)
        {
            CheckDeveloper();
            var developer = _developerService.Get<Developer>().Where(x => x.Name == login).FirstOrDefault();
            if (developer == null) return null;
            return developer.Password != password ? null : developer;
        }

        private void CheckDeveloper()
        {
            var developers = _developerService.Get<Developer>().ToList();

            if (!developers.Any())
            {
                var address = new Address
                {
                    State = "Sao Paulo",
                    City = "Birigui",
                };
                _addressService.Add<Address, Address, AddressValidator>(address);
                var developer = new Developer
                {
                    Name = "admin",
                    Password = "Admin2@",
                    Email = "admin@gmail.com",
                    Address = address,
                    RegisterDate = DateTime.Now.Date,
                };
                _developerService.Add<Developer, Developer, DeveloperValidator>(developer);
            }
        }
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Developer developer = GetDeveloper(txtLogin.Text, txtPassword.Text);
            if (developer == null)
            {
                MessageBox.Show("Login or Password invalid!", "Final Project",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                developer = _developerService.Update<Developer, Developer, DeveloperValidator>(developer);
                MainForm.developer = developer;
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
        #endregion

    }
}
