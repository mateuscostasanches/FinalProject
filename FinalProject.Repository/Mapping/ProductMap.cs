
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Repository.Mapping
{

    public class ProductMap : IEntityTypeConfiguration<Product>
    {

        #region configuration
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.HasOne(p => p.Developer).WithMany().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Category).WithMany().OnDelete(DeleteBehavior.Cascade);
        
        }
        #endregion 

    }

}