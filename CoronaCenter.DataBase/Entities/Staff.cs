using CoronaCenter.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
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
        public virtual IEnumerable<Medical_Staff> Medical_Staffs { get; set; }
    }
}
