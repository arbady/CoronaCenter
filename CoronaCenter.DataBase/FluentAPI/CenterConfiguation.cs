using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class CenterConfiguation : IEntityTypeConfiguration<Center>
    {
        public void Configure(EntityTypeBuilder<Center> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Center));

            //ma clé primaire
            builder.HasKey(c => c.Id);

            //auto-incremantation
            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(64);

            builder.Property(c => c.AddressId)
                   .IsRequired();
            
            builder.Property(c => c.ResponsibleId)
                   .IsRequired();

            //Relation

            builder.HasOne(c => c.Responsible)
                   .WithOne()
                   .HasForeignKey<Center>("ResponsibleId");

            builder.HasOne(w => w.Address)
                   .WithOne()
                   .HasForeignKey<Center>("AddressId");

            builder.HasMany(c => c.Lots)
                   .WithOne(l => l.Center);
            
            builder.HasMany(c => c.Calendars)
                   .WithOne(cal => cal.Center);
            
            builder.HasMany(c => c.Schedules)
                   .WithOne(sc => sc.Center);

            builder.HasMany(c => c.Vaccines)
                   .WithMany(v => v.Centers);

        }
    }
}