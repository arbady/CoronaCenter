using CoronaCenter.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.DataSet
{
    internal class StaffDataSet : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            Staff staff_1 = new()
            {
                Id = 1,
                Grade = Model.Enums.Grade.Doctor,
                Risponsible = true,
                UserId = 1
            }; builder.HasData(staff_1);

            Staff staff_2 = new()
            {
                Id = 2,
                Grade = Model.Enums.Grade.Nurse,
                Risponsible = false,
                UserId = 2
            }; builder.HasData(staff_2);

            Staff staff_3 = new()
            {
                Id = 3,
                Grade = Model.Enums.Grade.Security,
                Risponsible = false,
                UserId = 3
            }; builder.HasData(staff_3);
            
            Staff staff_4 = new()
            {
                Id = 4,
                Grade = Model.Enums.Grade.Security,
                Risponsible = false,
                UserId = 4
            }; builder.HasData(staff_4);
        }
    }
}
