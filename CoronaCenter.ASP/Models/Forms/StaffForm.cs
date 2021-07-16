using CoronaCenter.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class StaffForm
    {
        public int Id { get; set; }

        [Required]
        [EnumDataType(typeof(Grade))]
        public Grade Grade { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CenterId { get; set; }
    }
}
