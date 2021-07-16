using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class LotModel
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public int Quantity { get; set; }
        public int VaccineId { get; set; }
        public int CenterId { get; set; }
        public int WarehouseId { get; set; }
    }
}
