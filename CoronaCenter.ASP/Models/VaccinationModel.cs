using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class VaccinationModel
    {
        public int Id { get; set; }
        public int MedicalStaffId { get; set; }
        public int LotId { get; set; }
        public int CalandarId { get; set; }
    }
}
