using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoronaCenter.DataBase.FluentAPI
{
    public class MakerConfiguration : IEntityTypeConfiguration<Maker>
    {
        public void Configure(EntityTypeBuilder<Maker> builder)
        {
            //le nom de ma table
            builder.ToTable(nameof(Maker));

            //ma clé primaire
            builder.HasKey(m => m.Id);

            //auto-incremantation
            builder.Property(m => m.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(m => m.Name)
                   .IsRequired()
                   .HasMaxLength(64);

            //Relation

          
        }
    }
}