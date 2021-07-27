using CoronaCenter.DataBase;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Mapper;
using CoronaCenter.Services.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services
{
    public class ScheduleService : BaseProvider<Schedule, ScheduleModel, ScheduleForm>
    {
        public ScheduleService(DataContext dc) : base(dc, new ScheduleMapper())
        {
        }

        protected override Microsoft.EntityFrameworkCore.DbSet<Schedule> GetDbSet(DataContext dc)
        {
            return dc.Schedules;
        }
    }
}
