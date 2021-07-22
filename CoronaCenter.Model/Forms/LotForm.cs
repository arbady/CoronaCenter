using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Forms
{
    public class LotForm
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateIn { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int VaccineId { get; set; }

        [Required]
        public int CenterId { get; set; }

        [Required]
        public int WarehouseId { get; set; }
    }
}
