using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Forms
{
    public class PatientForm
    {
        public int Id { get; set; }

        [Required]
        [StringLength(13)]
        public string NISS { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [MaxLength(4000)]
        public string MedicalIndication { get; set; }

        //[Required]
        public int UserId { get; set; }

        //[Required]
        //public int AddressId { get; set; }

    }
}
