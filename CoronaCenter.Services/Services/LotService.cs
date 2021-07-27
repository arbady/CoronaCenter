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
    public class LotService : BaseProvider<Lot, LotModel, LotForm>
    {
        public LotService(DataContext dc) : base(dc, new LotMapper())
        {
        }

        protected override DbSet<Lot> GetDbSet(DataContext dc)
        {
            return dc.Lots;
        }
    }
}
