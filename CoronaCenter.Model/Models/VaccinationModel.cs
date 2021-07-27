using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class VaccinationModel : IDataModel<int>
    {
        public int Id { get; set; }
        public int MedicalStaffId { get; set; }
        public int LotId { get; set; }
        public int AppointmentId { get; set; }
        public MedicalStaff MedicalStaff { get; set; }
        public Lot Lot { get; set; }
        public Appointment Appointment { get; set; }
    }
}
