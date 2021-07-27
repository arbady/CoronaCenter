using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class ScheduleModel : IDataModel<int>
    {
        public int Id { get; set; }

        public Day Day { get; set; }
        public DateTime OpenHours { get; set; }
        public DateTime CloseHours { get; set; }
        public int CenterId { get; set; }
        //public Center Center { get; set; }
    }
}
