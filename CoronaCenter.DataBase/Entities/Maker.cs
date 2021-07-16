using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Maker : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Vaccine> Vaccines { get; set; }
    }
}
