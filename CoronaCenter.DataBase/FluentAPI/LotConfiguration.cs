using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class LotConfiguration : IEntityTypeConfiguration<Lot>
    {
        public void Configure(EntityTypeBuilder<Lot> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Lot));

            //ma clé primaire
            builder.HasKey(l => l.Id);

            //auto-incremantation
            builder.Property(l => l.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(l => l.DateIn)
                   .IsRequired()
                   .HasColumnType("Date")
                   .HasDefaultValueSql("GetDate()");

            builder.Property(l => l.Quantity)
                   .IsRequired();

            builder.Property(l => l.VaccineId)
                   .IsRequired();

            builder.Property(l => l.CenterId)
                   .IsRequired();

            builder.Property(l => l.WarehouseId)
                   .IsRequired();

            //Relation

            builder.HasOne(l => l.Vaccine)
                   .WithMany(v => v.Lots);
            
            builder.HasOne(l => l.Warehouse)
                   .WithMany(w => w.Lots);

            builder.HasMany(l => l.Vaccinations)
                   .WithOne(v => v.Lot);
        }
    }
}