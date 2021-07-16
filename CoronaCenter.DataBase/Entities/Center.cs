using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Center : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int ResponsibleId { get; set; }
        public virtual Address Address { get; set; }
        public virtual Staff Responsible { get; set; }
        public virtual IEnumerable<Staff> Staffs { get; set; }
        public virtual IEnumerable<Vaccine> Vaccines { get; set; }
        public virtual IEnumerable<Lot> Lots { get; set; }
        public virtual IEnumerable<Calendar> Calendars { get; set; }
        public virtual IEnumerable<Schedule> Schedules { get; set; }
    }
}
