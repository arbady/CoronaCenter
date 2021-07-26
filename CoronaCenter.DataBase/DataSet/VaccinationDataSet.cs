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
    internal class VaccinationDataSet : IEntityTypeConfiguration<Vaccination>
    {
        public void Configure(EntityTypeBuilder<Vaccination> builder)
        {
            Vaccination vacc_1 = new()
            {
                Id = 1,
                MedicalStaffId = 1,
                LotId = 1,
                AppointmentId = 1
            }; builder.HasData(vacc_1);

            Vaccination vacc_2 = new()
            {
                Id = 2,
                MedicalStaffId = 2,
                LotId = 1,
                AppointmentId = 2
            }; builder.HasData(vacc_2);
        }
    }
}
