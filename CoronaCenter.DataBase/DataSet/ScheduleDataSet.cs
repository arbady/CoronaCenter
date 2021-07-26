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
                OpenHours = "",
                CloseHours = new DateTime(),
                CenterId = 1
            }; builder.HasData(sch_1);
        }
    }
}
