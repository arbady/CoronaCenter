using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class VaccineForm
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public int MinInterval { get; set; }

        [Required]
        public int MaxInterval { get; set; }

        [Required]
        public int MakerId { get; set; }
    }
}
