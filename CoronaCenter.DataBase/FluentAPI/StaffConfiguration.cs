using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Staff));

            //ma clé primaire
            builder.HasKey(s => s.Id);

            //auto-incremantation
            builder.Property(s => s.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(s => s.Grade)
                   .IsRequired();

            builder.Property(s => s.UserId)
                   .IsRequired();

            //builder.Property(s => s.CenterId)
            //       .IsRequired();

            //Relation

            //builder.HasOne(s => s.Center)
            //       .WithMany(c => c.Staffs)
            //       .HasForeignKey(s => s.CenterId)
            //       .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.User)
                   .WithOne()
                   .HasForeignKey<Staff>("UserId");
        }
    }
}