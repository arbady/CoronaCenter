using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class Center_VaccineForm
    {
        public int Id { get; set; }

        [Required]
        public int CenterId { get; set; }

        [Required]
        public int VaccineId { get; set; }
    }
}
