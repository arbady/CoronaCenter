using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Schedule : IDataModel<int>
    {
        public int Id { get; set; }
        public Time OpenHours { get; set; }
        public Time CloseHours { get; set; }

        [Range(1,7)]
        public int DayNumber { get; set;}
        public int CenterId { get; set; }
        public virtual Center Center { get; set; }
    }
}
