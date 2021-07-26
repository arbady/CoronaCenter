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
    internal class MedicalStaffDataSet : IEntityTypeConfiguration<MedicalStaff>
    {
        public void Configure(EntityTypeBuilder<MedicalStaff> builder)
        {
            MedicalStaff mstaff_1 = new()
            {
                Id = 1,
                InamiNumber = "12345678911",
                StaffId = 1
            }; builder.HasData(mstaff_1);

            MedicalStaff mstaff_2 = new()
            {
                Id = 2,
                InamiNumber = "12345678912",
                StaffId = 2
            }; builder.HasData(mstaff_2);
        }
    }
}
