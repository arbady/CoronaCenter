using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoronaCenter.Model.Entities
{
    public class Lot : IDataModel<int>
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateIn { get; set; }
        public int Quantity { get; set; }
        public int VaccineId { get; set; }
        public int CenterId { get; set; }
        public int WarehouseId { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public virtual Center Center { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual IEnumerable<LotOut> Lot_Outs { get; set; }
        public virtual IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
