using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services.Bases;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace CoronaCenter.Services.Mapper
{
    public class UserMapper : IMapper<UserProfile, UserModel, UserForm>
    {
        public UserModel MapEntityToModel(UserProfile entity)
        {
            return new UserModel
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            };
        }

        public UserProfile MapFormToEntity(UserForm form)
        {
            UserProfile u = new UserProfile
            {
                Id = form.Id,
                FirstName = form.FirstName,
                LastName = form.LastName,
                Email = form.Email,
                Salt = Guid.NewGuid().ToString()
            };
            u.Password = PasswordHasher.Hashing<UserProfile>(u, form.Password, u => u.Salt);
            return u;
        }

        public UserProfile MapModelToEntity(UserModel model)
        {
            return new UserProfile
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
        }

        public UserForm MapModelToForm(UserModel model)
        {
            return new UserForm
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
        }
    }
}
