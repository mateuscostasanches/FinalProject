
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {

        #region configuration
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Customer);
            builder.Property(p => p.SaleDate);
            builder.Property(p => p.TotalSale);
            builder.HasMany(p => p.SaleItems).WithOne(p => p.Sale).OnDelete(DeleteBehavior.Cascade);
        }
        #endregion 

    }

    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {

        #region configuration
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Product);
            builder.HasOne(p => p.Developer);
            builder.Property(p => p.UnitPrice);
            builder.HasOne(p => p.Sale).WithMany(p => p.SaleItems).OnDelete(DeleteBehavior.Cascade);
        }
        #endregion 

    }

}