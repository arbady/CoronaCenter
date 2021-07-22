using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Appointment));

            //ma clé primaire
            builder.HasKey(c => c.Id);

            //auto-incremantation
            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.DateVacc)
                   .IsRequired()
                   .HasColumnType("Date")
                   .HasDefaultValueSql("GetDate()");

            builder.Property(c => c.HoursVacc)
                   .IsRequired();

            builder.Property(c => c.PatientId)
                   .IsRequired();

            builder.Property(c => c.CenterId)
                   .IsRequired();

            builder.Property(c => c.VaccineId)
                   .IsRequired();

            //Relation

            builder.HasOne(c => c.Patient)
                   .WithMany(p => p.Appointments)
                   .HasForeignKey(c => c.PatientId)
                   .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(c => c.Center)
                   .WithMany(ce => ce.Appointments)
                   .HasForeignKey(c => c.CenterId);
            
            builder.HasOne(c => c.Vaccine)
                   .WithMany(v => v.Appointments)
                   .HasForeignKey(c => c.VaccineId);

            builder.HasMany(c => c.Vaccinations)
                   .WithOne(va => va.Appointment);

            //Contrainte de verification
            builder.HasCheckConstraint("DateVacc", "[DateVacc] >= GetDate()");
        }
    }
}