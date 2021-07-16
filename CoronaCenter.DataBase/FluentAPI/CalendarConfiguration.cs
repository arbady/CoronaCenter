using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class CalendarConfiguration : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Calendar));

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
                   .WithMany(p => p.Calendars);
            
            builder.HasOne(c => c.Center)
                   .WithMany(ce => ce.Calendars);
            
            builder.HasOne(c => c.Vaccine)
                   .WithMany(v => v.Calendars);

            builder.HasMany(c => c.Vaccinations)
                   .WithOne(va => va.Calendar);
        }
    }
}