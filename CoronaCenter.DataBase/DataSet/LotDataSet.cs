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
    internal class LotDataSet : IEntityTypeConfiguration<Lot>
    {
        public void Configure(EntityTypeBuilder<Lot> builder)
        {
            builder.HasData(  
                new Lot
                {
                    Id = 1, 
                    DateIn = new DateTime(2021, 04, 30),
                    Quantity =  3000,
                    CenterId = 1,
                    VaccineId = 1,
                    WarehouseId = 1
                });

            builder.HasData(
                new Lot
                {
                    Id = 2,
                    DateIn = new DateTime(2021, 03, 20),
                    Quantity = 1000,
                    CenterId = 2,
                    VaccineId = 2,
                    WarehouseId = 2
                });

            builder.HasData(
                new Lot
                {
                    Id = 3,
                    DateIn = new DateTime(2021, 10, 14),
                    Quantity = 1500,
                    CenterId = 3,
                    VaccineId = 3,
                    WarehouseId = 3
                });

            builder.HasData(
                new Lot
                {
                    Id = 4,
                    DateIn = new DateTime(2021, 09, 12),
                    Quantity = 4200,
                    CenterId = 4,
                    VaccineId = 4,
                    WarehouseId = 4
                });
        }
    }
}
