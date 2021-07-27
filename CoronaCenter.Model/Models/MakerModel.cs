using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class MakerModel : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Vaccine> Vaccines { get; set; }
    }
}
