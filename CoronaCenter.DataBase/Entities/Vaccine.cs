using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Vaccine : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinInterval { get; set; }
        public int MaxInterval { get; set; }
        public int MakerId { get; set; }
        public virtual Maker Maker { get; set; }
        public virtual IEnumerable<Center> Centers { get; set; }
        public virtual IEnumerable<Calendar> Calendars { get; set; }
        public virtual IEnumerable<Lot> Lots { get; set; }
    }
}
