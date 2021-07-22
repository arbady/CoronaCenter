using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.Model.FluentAPI
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(UserProfile));

            //ma clé primaire
            builder.HasKey(u => u.Id);

            //auto-incremantation
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.FirstName)
                  .HasMaxLength(64)
                  .IsRequired();

            builder.Property(u => u.LastName)
                   .HasMaxLength(64)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(u => u.Password)
                   .IsRequired()
                   .HasColumnType("VARBINARY(32)");
            
            builder.Property(u => u.Salt)
                   .IsRequired()
                   .HasColumnType("CHAR(36)");

            //Contrainte de verification
            builder.HasCheckConstraint("CK_Email", "Email LIKE '__%@__%.%'")
                   //je mets un index et la contrainte d'unicité
                   .HasIndex(c => c.Email)
                   .IsUnique();
        }
    }
}