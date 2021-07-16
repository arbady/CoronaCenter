using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class Lot_OutModel
    {
        public int Id { get; set; }
        public DateTime DateOut { get; set; }
        public int Quantity { get; set; }
        public int LotId { get; set; }
    }
}
