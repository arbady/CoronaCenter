using CoronaCenter.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class CalendarForm
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateVacc { get; set; }
        public Time HoursVacc { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int CenterId { get; set; }

        [Required]
        public int VaccineId { get; set; }
    }
}
