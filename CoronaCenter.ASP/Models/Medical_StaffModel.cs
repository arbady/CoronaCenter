using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class Medical_StaffModel
    {
        public int Id { get; set; }
        public string InamiNumber { get; set; }
        public int StaffId { get; set; }
    }
}
