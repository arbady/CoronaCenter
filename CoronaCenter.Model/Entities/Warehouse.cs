using System.Collections.Generic;

namespace CoronaCenter.Model.Entities
{
    public class Warehouse : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual IEnumerable<Lot> Lots { get; set; }
    }
}
