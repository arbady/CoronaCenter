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
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services
{
    public class PatientService : BaseProvider<Patient, PatientModel, PatientForm>
    {
        public PatientService(DataContext db) : base(db, new PatientMapper())
        {
        }

        protected override DbSet<Patient> GetDbSet(DataContext dc)
        {
            return dc.Patients;
        }

        protected override IQueryable<Patient> PrepareQuery(DbSet<Patient> Entity)
        {
            return base.PrepareQuery(Entity)
                       .Include(p => p.Address)
                       .Include(p => p.User);
        }
    }
}
