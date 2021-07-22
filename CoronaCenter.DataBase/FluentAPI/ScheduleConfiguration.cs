using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Schedule));

            //ma clé primaire
            builder.HasKey(s => s.Id);

            //auto-incremantation
            builder.Property(s => s.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(s => s.Day)
                   .IsRequired();

            builder.Property(s => s.OpenHours)
                   .IsRequired();

            builder.Property(s => s.CloseHours)
                   .IsRequired();

            builder.Property(s => s.DayNumber)
                   .IsRequired();
            
            builder.Property(s => s.CenterId)
                   .IsRequired();

            //Relation

            //builder.HasOne(a => a.Reservation)
            //       .WithMany(r => r.Agences);
        }
    }
}