using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class VaccineConfiguration : IEntityTypeConfiguration<Vaccine>
    {
        public void Configure(EntityTypeBuilder<Vaccine> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Vaccine));

            //ma clé primaire
            builder.HasKey(v => v.Id);

            //auto-incremantation
            builder.Property(v => v.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(v => v.Name)
                   .IsRequired()
                   .HasMaxLength(64);

            builder.Property(v => v.MinInterval)
                   .IsRequired();

            builder.Property(v => v.MaxInterval)
                   .IsRequired();
            
            builder.Property(v => v.MakerId)
                   .IsRequired();

            //Contrainte de verification
            builder.HasCheckConstraint("CK_MinInterval", "MinInterval <= MaxInterval");

            //Relation

            builder.HasOne(v => v.Maker)
                   .WithMany();
        }
    }
}