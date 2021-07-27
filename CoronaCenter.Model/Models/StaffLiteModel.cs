using CoronaCenter.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class StaffLiteModel : IDataModel<int>
    {
        public int Id { get; set; }
        public Grade Grade { get; set; }
        public bool Risponsible { get; set; }
    }
}
