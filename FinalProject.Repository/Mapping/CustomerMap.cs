
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Repository.Mapping
{

    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        //Configure Method
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Nickname).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(250);
            builder.Property(p => p.RegisterDate);
            builder.Property(p => p.LoginDate);
            builder.Property(p => p.IsActive);
            builder.HasOne(p => p.Address);
        }

    }

}