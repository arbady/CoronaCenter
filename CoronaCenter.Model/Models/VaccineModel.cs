using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class VaccineModel : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinInterval { get; set; }
        public int MaxInterval { get; set; }
        public int MakerId { get; set; }
        public Maker Maker { get; set; }
    }
}
