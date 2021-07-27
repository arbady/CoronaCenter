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
    internal class ScheduleDataSet : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            Schedule sch_1 = new()
            {
                Id = 1,
                Day = Model.Enums.Day.Lundi,
                OpenHours = new DateTime(2021, 10, 09, 09, 00, 00),
                CloseHours = new DateTime(2021, 10, 09, 13, 00, 00),
                CenterId = 1
            }; builder.HasData(sch_1);

            Schedule sch_2 = new()
            {
                Id = 2,
                Day = Model.Enums.Day.Mardi,
                OpenHours = new DateTime(2021, 10, 09, 09, 00, 00),
                CloseHours = new DateTime(2021, 10, 09, 13, 00, 00),
                CenterId = 1
            }; builder.HasData(sch_2);

            Schedule sch_3 = new()
            {
                Id = 3,
                Day = Model.Enums.Day.Mercredi,
                OpenHours = new DateTime(2021, 10, 09, 09, 00, 00),
                CloseHours = new DateTime(2021, 10, 09, 13, 00, 00),
                CenterId = 2
            }; builder.HasData(sch_3);
        }
    }
}
