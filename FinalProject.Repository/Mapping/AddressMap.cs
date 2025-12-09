
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Repository.Mapping
{

    public class AddressMap : IEntityTypeConfiguration<Address>
    {

        #region configuration
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.City).IsRequired().HasMaxLength(50);
            builder.Property(p => p.State).IsRequired().HasMaxLength(50);
        }
        #endregion 

    }

}