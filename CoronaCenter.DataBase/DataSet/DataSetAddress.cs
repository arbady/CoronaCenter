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
    internal class DataSetAddress : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //Address add_1 = new()
            //{
            //    Id = 1,
            //    Province = Model.Enums.Province.Brabant_wallon,
            //    City = "Rixensart",
            //    ZipCode = 1040,
            //    Street = "Rue de la paix",
            //    Number = "10"
            //};

            //Address add_2 = new()
            //{
            //    Id = 2,
            //    Province = Model.Enums.Province.Hainaut,
            //    City = "Mons",
            //    ZipCode = 7000,
            //    Street = "Rue de l'Espinette",
            //    Number = "8"
            //};

            //Address add_3 = new()
            //{
            //    Id = 3,
            //    Province = Model.Enums.Province.Hainaut,
            //    City = "Charleroi",
            //    ZipCode = 6000,
            //    Street = "Rue des Oiseaux",
            //    Number = "5 Bis"
            //};

            //Address add_4 = new()
            //{
            //    Id = 4,
            //    Province = Model.Enums.Province.Liege,
            //    City = "Liège",
            //    ZipCode = 4000,
            //    Street = "Rue de la peur",
            //    Number = "1"
            //};
        }
    }
}
