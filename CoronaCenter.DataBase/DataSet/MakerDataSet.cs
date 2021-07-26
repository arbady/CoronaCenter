using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.DataSet
{
    internal class MakerDataSet : IEntityTypeConfiguration<Maker>
    {
        public void Configure(EntityTypeBuilder<Maker> builder)
        {
            builder.HasData(
                new Maker
                {
                    Id = 1,
                    Name = "BioNTech"
                });

            builder.HasData(
                new Maker
                {
                    Id = 2,
                    Name = "Oxford"
                });

            builder.HasData(
                new Maker
                {
                    Id = 3,
                    Name = "Moderna"
                });

            builder.HasData(
                new Maker
                {
                    Id = 4,
                    Name = "Johnson & Johnson"
                });
        }
    }
}
