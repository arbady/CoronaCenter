using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class AppointmentModel : IDataModel<int>
    {
        public int Id { get; set; }
        public DateTime DateVacc { get; set; }
        public DateTime HoursVacc { get; set; }
        public int PatientId { get; set; }
        public int CenterId { get; set; }
        public int VaccineId { get; set; }
        public Patient Patient { get; set; }
        public Center Center { get; set; }
        public Vaccine Vaccine { get; set; }
        public IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
