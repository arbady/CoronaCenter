﻿using CoronaCenter.DataBase;
using CoronaCenter.DataBase.Enums;
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

        [EnumDataType(typeof(Day))]
        public Day Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime OpenHours { get; set; }

        [DataType(DataType.Time)]
        public DateTime CloseHours { get; set; }
        public int DayNumber { get; set;}
        public int CenterId { get; set; }
    }
}
