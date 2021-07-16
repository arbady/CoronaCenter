using CoronaCenter.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class CalendarModel
    {
        public int Id { get; set; }
        public DateTime DateVacc { get; set; }
        public Time HoursVacc { get; set; }
        public int PatientId { get; set; }
        public int CenterId { get; set; }
        public int VaccineId { get; set; }
    }
}
