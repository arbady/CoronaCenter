using CoronaCenter.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoronaCenter.Model.Entities
{
    public class Staff : IDataModel<int>
    {
        public int Id { get; set; }

        [EnumDataType(typeof(Grade))]
        public Grade Grade { get; set; }
        public int UserId { get; set; }
        public int CenterId { get; set; }
        public virtual Center Center { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual IEnumerable<MedicalStaff> Medical_Staffs { get; set; }
    }
}
