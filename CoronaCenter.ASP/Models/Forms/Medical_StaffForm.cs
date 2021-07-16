using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class Medical_StaffForm
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string InamiNumber { get; set; }

        [Required]
        public int StaffId { get; set; }
    }
}
