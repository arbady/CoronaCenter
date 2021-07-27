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
    public class VaccineService : BaseProvider<Vaccine, VaccineModel, VaccineForm>
    {
        public VaccineService(DataContext dc) : base(dc, new VaccineMapper())
        {
        }

        protected override DbSet<Vaccine> GetDbSet(DataContext dc)
        {
            return dc.Vaccines;
        }
        protected override IQueryable<Vaccine> PrepareQuery(DbSet<Vaccine> Entity)
        {
            return base.PrepareQuery(Entity)
                       .Include(v => v.Centers);
        }
    }
}
