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
    internal class WarehouseDataSet : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            Warehouse war_1 = new()
            {
                Id = 1,
                Name = "Entrepot Numero1",
                AddressId = 5
            }; builder.HasData(war_1);

            Warehouse war_2 = new()
            {
                Id = 2,
                Name = "Entrepot Numero2",
                AddressId = 6
            }; builder.HasData(war_2);

            Warehouse war_3 = new()
            {
                Id = 3,
                Name = "Entrepot Numero3",
                AddressId = 7
            }; builder.HasData(war_3);

            Warehouse war_4 = new()
            {
                Id = 4,
                Name = "Entrepot Numero4",
                AddressId = 8
            }; builder.HasData(war_4);
        }
    }
}
