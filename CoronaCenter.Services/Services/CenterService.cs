using CoronaCenter.DataBase;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Mapper;
using CoronaCenter.Services.Services.Bases;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoronaCenter.Services.Services
{
    public class CenterService : BaseProvider<Center, CenterModel, CenterForm>
    {
        public CenterService(DataContext dc) : base(dc, new CenterMapper())
        {
        }

        protected override DbSet<Center> GetDbSet(DataContext dc)
        {
            return dc.Centers;
        }
        protected override IQueryable<Center> PrepareQuery(DbSet<Center> Entity)
        {
            return base.PrepareQuery(Entity)
                       .Include(c => c.Staffs).ThenInclude(s => s.User)
                       .Include(c => c.Staffs).ThenInclude(s => s.Medical_Staffs)
                       .Include(c => c.Address)
                       .Include(c => c.Schedules)
                       .Include(c => c.Appointments).ThenInclude(a => a.Vaccine)
                       .Include(c => c.Lots)
                       .Include(c => c.Responsible).ThenInclude(r => r.User)
                       .Include(c => c.Responsible).ThenInclude(r => r.Medical_Staffs);
        }
    }
}
