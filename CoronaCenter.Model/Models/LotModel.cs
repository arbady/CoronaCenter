using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    public class LotModel : IDataModel<int>
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public int Quantity { get; set; }
        public int VaccineId { get; set; }
        public int CenterId { get; set; }
        public int WarehouseId { get; set; }
        public Vaccine Vaccine { get; set; }
        public Center Center { get; set; }
        public Warehouse Warehouse { get; set; }
        public IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
