using CoronaCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        public Time OpenHours { get; set; }
        public Time CloseHours { get; set; }
        public int DayNumber { get; set;}
        public int CenterId { get; set; }
    }
}
