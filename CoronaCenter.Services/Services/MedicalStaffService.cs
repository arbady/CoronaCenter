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
    public class MedicalStaffService : BaseServices<MedicalStaff, MedicalStaffModel, MedicalStaffForm>
    {
        public MedicalStaffService(DataContext dc) : base(dc, new MedicalStaffMapper())
        {
        }

        protected override DbSet<MedicalStaff> GetDbSet(DataContext dc)
        {
            return dc.Medical_Staffs;
        }
        protected override IQueryable<MedicalStaff> PrepareQuery(DbSet<MedicalStaff> Entity)
        {
            return base.PrepareQuery(Entity)
                       .Include(m => m.Staff)
                       .ThenInclude(m => m.User);
        }
    }
}
