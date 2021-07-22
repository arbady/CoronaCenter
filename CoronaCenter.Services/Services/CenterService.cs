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
    public class CenterService : BaseServices<Center, CenterModel, CenterForm>
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
                       .Include(c => c.Address)
                       .Include(c => c.Responsible);
        }
    }
}
