using FinalProject.Domain.Entities;
using FinalProject.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository.Context
{

    public class FinalProjectContext : DbContext
    {

        #region Constructors
        public FinalProjectContext(DbContextOptions<FinalProjectContext>? op=null) : base(op)
        {
            Database.EnsureCreated();
        }

        public FinalProjectContext()
        {
            
        }
        #endregion 

        #region  Configure Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=FinalProject;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Address>(new AddressMap().Configure);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<Customer>(new CustomerMap().Configure);
            modelBuilder.Entity<Developer>(new DeveloperMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<Sale>(new SaleMap().Configure);
            modelBuilder.Entity<SaleItem>(new SaleItemMap().Configure);
        }
        #endregion 

        #region DbSets getters and setters
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        #endregion

    }

}