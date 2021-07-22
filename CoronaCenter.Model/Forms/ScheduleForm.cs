using CoronaCenter.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoronaCenter.Model.Forms
{
    public class ScheduleForm
    {
        public int Id { get; set; }

        [EnumDataType(typeof(Day))]
        public Day Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime OpenHours { get; set; }

        [DataType(DataType.Time)]
        public DateTime CloseHours { get; set; }

        [Required]
        public int CenterId { get; set; }
    }
}
