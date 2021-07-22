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
    internal class DataSetStaff : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            Staff staff_1 = new()
            {
                Id = 1,
                Grade = Model.Enums.Grade.Doctor,
                UserId = 1,
                CenterId = 1
            };
            
            Staff staff_2 = new()
            {
                Id = 2,
                Grade = Model.Enums.Grade.Nurse,
                UserId = 2,
                CenterId = 1
            };
            
            Staff staff_3 = new()
            {
                Id = 3,
                Grade = Model.Enums.Grade.Security,
                UserId = 3,
                CenterId = 1
            };
        }
    }
}
