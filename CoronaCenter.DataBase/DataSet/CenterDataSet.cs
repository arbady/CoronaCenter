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
    internal class CenterDataSet : IEntityTypeConfiguration<Center>
    {
        public void Configure(EntityTypeBuilder<Center> builder)
        {
            Center c_1 = new()
            {
                Id = 1,
                Name = "CV Numero1",
                AddressId = 9,
                ResponsibleId = 1
            };
            builder.HasData(c_1);

            Center c_2 = new()
            {
                Id = 2,
                Name = "CV Numero2",
                AddressId = 10,
                ResponsibleId = 2
            };
            builder.HasData(c_2);
            Center c_3 = new()
            {
                Id = 3,
                Name = "CV Numero3",
                AddressId = 11,
                ResponsibleId = 3
            };
            builder.HasData(c_3);

            Center c_4 = new()
            {
                Id = 4,
                Name = "CV Numero4",
                AddressId = 12,
                ResponsibleId = 4
            };
            builder.HasData(c_4);
        }
    }
}
