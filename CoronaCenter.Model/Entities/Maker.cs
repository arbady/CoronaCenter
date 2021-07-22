using System.Collections.Generic;

namespace CoronaCenter.Model.Entities
{
    public class Maker : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Vaccine> Vaccines { get; set; }
    }
}
