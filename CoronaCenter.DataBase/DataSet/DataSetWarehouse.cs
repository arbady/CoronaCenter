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
    class DataSetWarehouse : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            Warehouse add_1 = new()
            {
                Id = 1,
                Name = "Centre de Mons",
                Address = new()
                {
                    Id = 2,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Mons",
                    ZipCode = 7000,
                    Street = "Rue de l'Espinette",
                    Number = "8"
                }
            };
        }
    }
}
