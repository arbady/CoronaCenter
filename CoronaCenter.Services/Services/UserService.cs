using CoronaCenter.DataBase;
using CoronaCenter.Model;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Mapper;
using CoronaCenter.Services.Services.Bases;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace CoronaCenter.Services.Services
{
    public class UserService : BaseProvider<UserProfile, UserModel, UserForm>, IUserService
    {
        public UserService(DataContext dc) : base(dc, new UserMapper())
        {
        }

        protected override DbSet<UserProfile> GetDbSet(DataContext dc)
        {
            return dc.Users;
        }

        private Func<UserProfile, UserPublic> mapping =
        (pro) =>
        {
            if (pro is null) return null;
            return new UserPublic
            {
                Id = pro.Id,
                FirstName = pro.FirstName,
                LastName = pro.LastName,
                Email = pro.Email,
                Token = null
            };
        };

        public UserPublic Check(string mail, string password)
        {
            UserProfile user = Dc.Users
                                        .Include(u => u.Staff)
                                        .Include(u => u.Patient)
                                        .Where(u => u.Email == mail).SingleOrDefault();
            
            if (user == null) return null;
            byte[] possiblePassword = PasswordHasher.Hashing(user, password, p => p.Salt);

            if (possiblePassword.SequenceEqual(user.Password)) {
                
                UserPublic up = mapping(user);

                if (!(user.Staff is null))
                {
                    //if (!(user.Staff.))
                    //{

                    //}
                    up.Role = Model.Enums.Role.Staff;
                }
                else
                {
                    up.Role = Model.Enums.Role.Patient;
                }
                return up; 
            }

            return null;
            
        }

        public IEnumerable<UserPublic> Get()
        {
            return Dc.Users.Select(u => mapping(u)).ToList();
        }

        public UserPublic Get(int id)
        {
            return mapping(Dc.Users.SingleOrDefault(u => u.Id == id));
        }

       
    }
}
