using CoronaCenter.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class StaffModel
    {
        public int Id { get; set; }
        public Grade Grade { get; set; }
        public int UserId { get; set; }
        public int CenterId { get; set; }
    }
}
