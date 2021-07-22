using CoronaCenter.DataBase;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Mapper;
using CoronaCenter.Services.Services.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services
{
    public class StaffService : BaseServices<Staff, StaffModel, StaffForm>
    {
        public StaffService(DataContext dc) : base(dc, new StaffMapper())
        {
        }

        protected override DbSet<Staff> GetDbSet(DataContext dc)
        {
            return dc.Staffs;
        }
        protected override IQueryable<Staff> PrepareQuery(DbSet<Staff> Entity)
        {
            return base.PrepareQuery(Entity)
                       .Include(s => s.User)
                       .Include(s => s.Center);
        }
    }
}
