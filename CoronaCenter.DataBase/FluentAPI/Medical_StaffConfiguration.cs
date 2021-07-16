using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class Medical_StaffConfiguration : IEntityTypeConfiguration<Medical_Staff>
    {
        public void Configure(EntityTypeBuilder<Medical_Staff> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Medical_Staff));

            //ma clé primaire
            builder.HasKey(m => m.Id);

            //auto-incremantation
            builder.Property(m => m.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(m => m.InamiNumber)
                   .IsRequired()
                   .HasColumnType("CHAR(11)");

            builder.Property(m => m.StaffId)
                   .IsRequired();

            //Contrainte de verification
            builder.HasIndex(m => m.InamiNumber)
                   .IsUnique();  //je mets un index et la contrainte d'unicité

            //Relation

            builder.HasMany(m => m.Vaccinations)
                   .WithOne(v => v.MedicalStaff)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Staff)
                   .WithMany(s => s.Medical_Staffs);
        }
    }
}