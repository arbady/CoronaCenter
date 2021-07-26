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
    internal class VaccineDataSet : IEntityTypeConfiguration<Vaccine>
    {
        public void Configure(EntityTypeBuilder<Vaccine> builder)
        {
            builder.HasData(
                new Vaccine
                {
                    Id = 1,
                    Name = "Pfizer",
                    MinInterval = 1,
                    MaxInterval = 2,
                    MakerId = 1
                });

            builder.HasData(
                new Vaccine
                {
                    Id = 2,
                    Name = "AstraZeneca",
                    MinInterval = 1,
                    MaxInterval = 2,
                    MakerId = 2
                });

            builder.HasData(
                new Vaccine
                {
                    Id = 3,
                    Name = "Moderna",
                    MinInterval = 1,
                    MaxInterval = 2,
                    MakerId = 3
                });

            builder.HasData(
                new Vaccine
                {
                    Id = 4,
                    Name = "Johnson & Johnson",
                    MinInterval = 1,
                    MaxInterval = 2,
                    MakerId = 4
                });
        }
    }
}
