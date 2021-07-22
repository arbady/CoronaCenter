using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Forms
{
    public class VaccinationForm
    {
        public int Id { get; set; }

        [Required]
        public int MedicalStaffId { get; set; }

        [Required]
        public int LotId { get; set; }

        [Required]
        public int CalandarId { get; set; }
    }
}
