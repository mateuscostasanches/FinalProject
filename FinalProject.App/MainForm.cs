
using ReaLTaiizor.Forms;
using FinalProject.App.Infra;
using FinalProject.App.Others;
using FinalProject.App.Register;
using FinalProject.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FinalProject.App
{
    public partial class MainForm : LostForm
    {

        #region Variable
        public static Developer developer { get; set; }
        #endregion 

        #region Constructor
        public MainForm()
        {
            LoadLogin();
            InitializeComponent();
        }
        #endregion 

        #region ClickMenuStrip Events
        private void newAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<AddressForm>();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CategoryForm>();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CustomerForm>();
        }

        private void newDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<DeveloperForm>();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm<ProductForm>();
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<SaleForm>();
        }
        #endregion

        #region Method
        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed) cad.ShowDialog();

        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<LoginForm>();
            if (login != null && !login.IsDisposed)
            {
                if(login.ShowDialog() != DialogResult.OK) Environment.Exit(0);
            }
        }
        
        #endregion

    }

}
