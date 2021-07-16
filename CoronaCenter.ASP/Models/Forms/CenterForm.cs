using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class CenterForm
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int ResponsibleId { get; set; }
        public StaffModel Responsable { get; set; }
    }
}
