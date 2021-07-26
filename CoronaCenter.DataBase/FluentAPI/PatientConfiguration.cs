using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Patient));

            //ma clé primaire
            builder.HasKey(p => p.Id);

            //auto-incremantation
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.NISS)
                   .IsRequired()
                   .HasColumnType("CHAR(13)");

            builder.Property(p => p.DateOfBirth)
                   .IsRequired()
                   .HasColumnType("Date")
                   .HasDefaultValueSql("GetDate()");

            builder.Property(p => p.PhoneNumber)
                   .IsRequired();

            builder.Property(p => p.MedicalIndication)
                   .IsRequired()
                   .HasMaxLength(4000);

            builder.Property(p => p.UserId)
                   .IsRequired();

            builder.Property(p => p.AddressId)
                   .IsRequired();

            //Contrainte de verification
            builder.HasIndex(p => p.NISS)
                   .IsUnique();  //je mets un index et la contrainte d'unicité

            //Relation

            builder.HasOne(p => p.User)
                   .WithOne()
                   .HasForeignKey<Patient>("UserId");

            builder.HasOne(w => w.Address)
                   .WithOne()
                   .HasForeignKey<Patient>("AddressId");

            //builder.HasMany(p => p.Calendars)
            //       .WithOne(u => u.Patient);


            //Constraint
            //builder.HasCheckConstraint("CK_Patient", "NISS LIKE '[0-9][0-9].[0-9][0-9].[0-9][0-9]-[0-9][0-9][0-9].[0-9][0-9]'")
            //       //je mets un index et la contrainte d'unicité
            //       .HasIndex(c => c.NISS)
            //       .IsUnique();

        }
    }
}