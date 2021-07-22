using CoronaCenter.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoronaCenter.Model.Forms
{
    public class AppointmentForm
    {
        public int Id { get; set; }

        [Required]
        [EnumDataType(typeof(Day))]
        public Day Day { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateVacc { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime HoursVacc { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int CenterId { get; set; }

        [Required]
        public int VaccineId { get; set; }
    }
}
