using CoronaCenter.Model.Forms;
using CoronaCenter.DataBase;
using CoronaCenter.Model.Entities;
using CoronaCenter.Services.Services.Bases;
using System.Collections.Generic;
using System.Linq;
using CoronaCenter.Model.Models;
using Microsoft.EntityFrameworkCore;
using CoronaCenter.Services.Mapper;

namespace CoronaCenter.Services.Services
{
    public class MakerService : BaseServices<Maker, MakerModel, MakerForm>
    {
        public MakerService(DataContext db) : base(db, new MakerMapper())
        {
        }

        protected override DbSet<Maker> GetDbSet(DataContext dc)
        {
            return dc.Makers;
        }
    }
}
