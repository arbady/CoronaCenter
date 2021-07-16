using CoronaCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class ScheduleForm
    {
        public int Id { get; set; }
        public Time OpenHours { get; set; }
        public Time CloseHours { get; set; }

        [Required]
        [Range(1,7)]
        public int DayNumber { get; set;}

        [Required]
        public int CenterId { get; set; }
    }
}
