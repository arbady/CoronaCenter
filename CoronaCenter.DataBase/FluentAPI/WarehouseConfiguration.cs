using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Warehouse));

            //ma clé primaire
            builder.HasKey(w => w.Id);

            //auto-incremantation
            builder.Property(w => w.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(w => w.Name)
                   .IsRequired()
                   .HasMaxLength(64);

            builder.Property(w => w.AddressId)
                   .IsRequired();

            //Relation

            builder.HasOne(w => w.Address)
                   .WithOne()
                   .HasForeignKey<Warehouse>("AddressId");
        }
    }
}