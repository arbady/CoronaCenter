using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Address));

            //ma clé primaire
            builder.HasKey(a => a.Id);

            //auto-incremantation
            builder.Property(a => a.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(a => a.Province)
                   .IsRequired();

            builder.Property(a => a.City)
                   .IsRequired()
                   .HasMaxLength(64);

            builder.Property(a => a.ZipCode)
                   .IsRequired();

            builder.Property(a => a.Street)
                   .IsRequired()
                   .HasMaxLength(64);

            builder.Property(a => a.Number)
                   .IsRequired()
                   .HasMaxLength(13); 
        }
    }
}
