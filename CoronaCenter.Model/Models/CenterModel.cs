using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class CenterModel : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int ResponsibleId { get; set; }
        public AddressModel Address { get; set; }
        public StaffLiteModel Responsible { get; set; }
        public IEnumerable<VaccineModel> Vaccines { get; set; }
        public IEnumerable<ScheduleModel> Schedules { get; set; }
    }
}
