using CoronaCenter.Model.Entities;
using Microsoft.AspNetCore.Identity;
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
    internal class UserDataSet : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            UserProfile user_1 = new()
            {
                Id = 1,
                FirstName = "Arnold",
                LastName = "Mpoyi",
                Email = "arnoldmpoyi@yahoo.fr",
                Salt = Guid.NewGuid().ToString()
            };
            user_1.Password = PasswordHasher.Hashing<UserProfile>(user_1, "test1234=", u => u.Salt);
            builder.HasData(user_1);


            UserProfile user_2 = new()
            {
                Id = 2,
                FirstName = "Corentin",
                LastName = "De Block",
                Email = "cocodeblock@gmail.com",
                Salt = Guid.NewGuid().ToString()
            };
            user_2.Password = PasswordHasher.Hashing<UserProfile>(user_2, "test1234=", u => u.Salt);
            builder.HasData(user_2);


            UserProfile user_3 = new()
            {
                Id = 3,
                FirstName = "Isabel",
                LastName = "Skou",
                Email = "IsaSkou@yahoo.com",
                Salt = Guid.NewGuid().ToString()
            };
            user_3.Password = PasswordHasher.Hashing<UserProfile>(user_3, "test1234=", u => u.Salt);
            builder.HasData(user_3);
            
            UserProfile user_4 = new()
            {
                Id = 4,
                FirstName = "Steve",
                LastName = "Buanga",
                Email = "badispace@gmail.com",
                Salt = Guid.NewGuid().ToString()
            };
            user_4.Password = PasswordHasher.Hashing<UserProfile>(user_4, "test1234=", u => u.Salt);
            builder.HasData(user_4);

            UserProfile user_5 = new()
            {
                Id = 5,
                FirstName = "Toto",
                LastName = "Tata",
                Email = "tototata@gmail.com",
                Salt = Guid.NewGuid().ToString()
            };
            user_5.Password = PasswordHasher.Hashing<UserProfile>(user_5, "test1234=", u => u.Salt);
            builder.HasData(user_5);

            //builder.HasData(
            //    new UserProfile
            //    {
            //        Id = 1,
            //        FirstName = "Arnold",
            //        LastName = "Mpoyi",
            //        Email = "arnoldmpoyi@yahoo.fr",
            //        Salt = Guid.NewGuid().ToString()
            //    });

            //user_1.Password = PasswordHasher.Hashing<UserProfile>(user_1, "test1234=", u => u.Salt);
        }
    }
}
