using CoronaCenter.Model.Entities;
using System.Collections.Generic;

namespace CoronaCenter.Model.Entities
{
    public class MedicalStaff : IDataModel<int>
    {
        public int Id { get; set; }
        public string InamiNumber { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
