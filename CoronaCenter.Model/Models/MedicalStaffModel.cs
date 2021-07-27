using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class MedicalStaffModel : IDataModel<int>
    {
        public int Id { get; set; }
        public string InamiNumber { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
