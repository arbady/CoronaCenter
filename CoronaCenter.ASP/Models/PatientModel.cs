using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string NISS { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string MedicalIndication { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
    }
}
