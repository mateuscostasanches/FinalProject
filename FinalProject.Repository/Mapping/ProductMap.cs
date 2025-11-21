
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Repository.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {

        //Configure Method
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.PurchaseDate);
            builder.HasOne(p => p.Category);
            builder.HasMany(p => p.Achivements);

        }

    }
    public class AchivementMap : IEntityTypeConfiguration<Achivement>
    {
        //Configure Method
        public void Configure(EntityTypeBuilder<Achivement> builder)
        {
            builder.ToTable("Achivements");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.IsAchived);
            builder.HasOne(p => p.Product);
            builder.HasOne(p => p.Product).WithMany(p => p.Achivements).OnDelete(DeleteBehavior.Cascade);
        }

    }

}