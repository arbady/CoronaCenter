using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Vaccination : IDataModel<int>
    {
        public int Id { get; set; }
        public int MedicalStaffId { get; set; }
        public int LotId { get; set; }
        public int CalandarId { get; set; }
        public virtual Medical_Staff MedicalStaff { get; set; }
        public virtual Lot Lot { get; set; }
        public virtual Calendar Calendar { get; set; }
    }
}
