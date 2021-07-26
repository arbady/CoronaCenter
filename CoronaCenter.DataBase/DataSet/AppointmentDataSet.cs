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
    internal class AppointmentDataSet : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasData(
                new Appointment
                {
                    Id = 1,
                    DateVacc = new DateTime(2021, 10, 09),
                    HoursVacc = new DateTime().AddMinutes(15),
                    PatientId = 1,
                    CenterId = 1,
                    VaccineId = 1
                });

            builder.HasData(
                new Appointment
                {
                    Id = 2,
                    DateVacc = new DateTime(2021, 10, 15),
                    HoursVacc = new DateTime().AddMinutes(15),
                    PatientId = 2,
                    CenterId = 1,
                    VaccineId = 2
                });
        }
    }
}
