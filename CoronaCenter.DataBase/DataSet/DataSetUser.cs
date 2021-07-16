using CoronaCenter.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace CoronaCenter.DataBase.DataSet
{
    public class DataSetUser : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            UserProfile user_1 = new UserProfile
            {
                Id = 1,
                FirstName = "Samuel",
                LastName = "Legrain",
                Email = "samuel.legrain@bstorm.be",
                Salt = Guid.NewGuid().ToString()
            };
            user_1.Password = PasswordHasher.Hashing<UserProfile>(user_1, "test1234=", u => u.Salt);
            builder.Entity<UserProfile>().HasData(user_1);
        }

    }
}
