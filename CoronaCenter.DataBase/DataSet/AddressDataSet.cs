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
    internal class AddressDataSet : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(  
                new Address
                {
                    Id = 1,
                    Province = Model.Enums.Province.Brabant_wallon,
                    City = "Rixensart",
                    ZipCode = 1040,
                    Street = "Rue de la paix",
                    Number = "10"
                });

            builder.HasData(
                new Address
                {
                    Id = 2,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Mons",
                    ZipCode = 7000,
                    Street = "Rue de l'Espinette",
                    Number = "8"
                });

            builder.HasData(
                new Address
                {
                    Id = 3,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Charleroi",
                    ZipCode = 6000,
                    Street = "Rue des Oiseaux",
                    Number = "5 Bis"
                });

            builder.HasData(
                new Address
                {
                    Id = 4,
                    Province = Model.Enums.Province.Liege,
                    City = "Liège",
                    ZipCode = 4000,
                    Street = "Rue de la peur",
                    Number = "1"
                });

            builder.HasData(
                new Address
                {
                    Id = 5,
                    Province = Model.Enums.Province.Namur,
                    City = "Namur",
                    ZipCode = 5000,
                    Street = "Rue du bonheur",
                    Number = "121"
                });

            builder.HasData(
                new Address
                {
                    Id = 6,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Frameries",
                    ZipCode = 7080,
                    Street = "Clos des Ormes",
                    Number = "2/3"
                });

            builder.HasData(
                new Address
                {
                    Id = 7,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Colfontaine",
                    ZipCode = 7340,
                    Street = "Cité de l'Abbaye",
                    Number = "14A"
                });

            builder.HasData(
                new Address
                {
                    Id = 8,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Saint-Ghislain",
                    ZipCode = 7330,
                    Street = "Cité des pétetites préelles",
                    Number = "53"
                });

            builder.HasData(
                new Address
                {
                    Id = 9,
                    Province = Model.Enums.Province.Hainaut,
                    City = "Tournai",
                    ZipCode = 7500,
                    Street = "Cité des anges",
                    Number = "13"
                });

            builder.HasData(
                new Address
                {
                    Id = 10,
                    Province = Model.Enums.Province.Liege,
                    City = "Huy",
                    ZipCode = 4500,
                    Street = "Rue Simone de Bondue",
                    Number = "57"
                });

            builder.HasData(
                new Address
                {
                    Id = 11,
                    Province = Model.Enums.Province.Namur,
                    City = "Diant",
                    ZipCode = 5500,
                    Street = "Impasse des maraichers",
                    Number = "83"
                });

            builder.HasData(
                new Address
                {
                    Id = 12,
                    Province = Model.Enums.Province.Brabant_wallon,
                    City = "BoitsFort",
                    ZipCode = 1170,
                    Street = "Rue Grande",
                    Number = "106c"
                });
        }
    }
}
