using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Forms
{
    public class MedicalStaffForm
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string InamiNumber { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
