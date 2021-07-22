using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class Lot_OutForm
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateOut { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int LotId { get; set; }
    }
}
