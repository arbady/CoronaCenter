using CoronaCenter.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoronaCenter.Model.Entities
{
    public class Schedule : IDataModel<int>
    {
        public int Id { get; set; }

        [EnumDataType(typeof(Day))]
        public Day Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime OpenHours { get; set; }

        [DataType(DataType.Time)]
        public DateTime CloseHours { get; set; }

        [Range(1,7)]
        public int DayNumber { get; set;}
        public int CenterId { get; set; }
        public virtual Center Center { get; set; }
    }
}
