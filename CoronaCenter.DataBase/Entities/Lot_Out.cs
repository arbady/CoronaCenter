using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Lot_Out
    {
        public int Id { get; set; }
        public DateTime DateOut { get; set; }
        public int Quantity { get; set; }
        public int LotId { get; set; }
        public virtual Lot Lot { get; set; }
    }
}
