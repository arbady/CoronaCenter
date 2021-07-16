using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class VaccinationConfiguration : IEntityTypeConfiguration<Vaccination>
    {
        public void Configure(EntityTypeBuilder<Vaccination> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Vaccination));

            //ma clé primaire
            builder.HasKey(v => v.Id);

            //auto-incremantation
            builder.Property(v => v.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(v => v.MedicalStaffId)
                   .IsRequired();

            builder.Property(v => v.LotId)
                   .IsRequired();

            builder.Property(v => v.AppointmentId)
                   .IsRequired();

            //Relation

            //builder.HasOne(a => a.Reservation)
            //       .WithMany(r => r.Agences);
        }
    }
}