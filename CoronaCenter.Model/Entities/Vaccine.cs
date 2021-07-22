using System.Collections.Generic;

namespace CoronaCenter.Model.Entities
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
        public virtual IEnumerable<Appointment> Appointments { get; set; }
        public virtual IEnumerable<Lot> Lots { get; set; }
    }
}
