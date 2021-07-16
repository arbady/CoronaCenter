using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Calendar : IDataModel<int>
    {
        public int Id { get; set; }
        public DateTime DateVacc { get; set; }
        public Time HoursVacc { get; set; }
        public int PatientId { get; set; }
        public int CenterId { get; set; }
        public int VaccineId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Center Center { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public virtual IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
