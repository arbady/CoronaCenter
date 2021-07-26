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
    internal class PatientDataSet : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            Patient p_1 = new()
            {
                Id = 1,
                NISS = "86043058162",
                DateOfBirth = new DateTime(1986, 04, 30),
                PhoneNumber = "0466423930",
                MedicalIndication = "Test",
                UserId = 5,
                AddressId = 1
            }; builder.HasData(p_1);
        }
    }
}
