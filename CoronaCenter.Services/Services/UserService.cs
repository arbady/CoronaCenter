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
    public class UserService : BaseProvider<UserProfile, UserModel, UserForm>
    {
        public UserService(DataContext dc) : base(dc, new UserMapper())
        {
        }

        protected override DbSet<UserProfile> GetDbSet(DataContext dc)
        {
            return dc.Users;
        }
    }
}
