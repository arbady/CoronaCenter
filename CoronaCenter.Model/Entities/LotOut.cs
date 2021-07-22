using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Entities
{
    public class LotOut
    {
        public int Id { get; set; }
        public DateTime DateOut { get; set; }
        public int Quantity { get; set; }
        public int LotId { get; set; }
        public virtual Lot Lot { get; set; }
    }
}
