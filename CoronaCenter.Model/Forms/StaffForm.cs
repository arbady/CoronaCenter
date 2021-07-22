using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Forms
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
        public UserProfile User { get; set; }
        public Center Center { get; set; }
    }
}
