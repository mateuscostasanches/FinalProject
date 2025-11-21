using FinalProject.Domain.Entities;
using FinalProject.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository.Context
{

    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext(DbContextOptions<FinalProjectContext>? op = null) : base(op)
        {
            Database.EnsureCreated();
        }

        //Configure Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=FinalProject;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Achivement>(new AchivementMap().Configure);
            modelBuilder.Entity<Address>(new AddressMap().Configure);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<Customer>(new CustomerMap().Configure);
            modelBuilder.Entity<Developer>(new DeveloperMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<Sale>(new SaleMap().Configure);
            modelBuilder.Entity<SaleItem>(new SaleItemMap().Configure);
        }

        #region DbSets getters and setters
        public DbSet<Address> Achivements { get; set; }
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