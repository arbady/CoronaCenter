using CoronaCenter.DataBase;
using CoronaCenter.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }

        public DateTime DateVacc { get; set; }

        [DataType(DataType.Time)]
        public DateTime HoursVacc { get; set; }
        public int PatientId { get; set; }
        public int CenterId { get; set; }
        public int VaccineId { get; set; }
    }
}
