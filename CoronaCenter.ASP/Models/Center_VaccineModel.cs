using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class Center_VaccineModel
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int VaccineId { get; set; }
    }
}
