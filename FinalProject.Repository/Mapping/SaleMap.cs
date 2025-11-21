
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        //Configure Method
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SaleDate);
            builder.HasOne(p => p.Developer);
            builder.HasOne(p => p.Customer);
            builder.HasMany(p => p.SaleItems).WithOne(p => p.Sale).OnDelete(DeleteBehavior.Cascade);
        }

    }

    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        //Configure Method
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UnityPrice);
            builder.Property(p => p.TotalPrice);
            builder.Property(p => p.Quantity);
            builder.Property(p => p.Discount);
            builder.HasOne(p => p.Product);
            builder.HasOne(p => p.Sale).WithMany(p => p.SaleItems).OnDelete(DeleteBehavior.Cascade);
        }

    }

}