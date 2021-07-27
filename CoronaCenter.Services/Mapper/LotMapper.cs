using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Mapper
{
    public class LotMapper : BaseMapper, IMapper<Lot, LotModel, LotForm>
    {
        public LotModel MapEntityToModel(Lot entity)
        {
            if (CheckIfNull(entity)) return null;

            return new LotModel
            {
                Id = entity.Id,
                DateIn = entity.DateIn,
                Quantity = entity.Quantity,
                VaccineId = entity.VaccineId,
                CenterId =entity.CenterId,
                WarehouseId = entity.WarehouseId, 
                Vaccinations = entity.Vaccinations, 
                Vaccine = entity.Vaccine, 
                Center = entity.Center, 
                Warehouse = entity.Warehouse
            };
        }

        public Lot MapFormToEntity(LotForm form)
        {
            if (CheckIfNull(form)) return null;

            return new Lot
            {
                Id = form.Id,
                DateIn = form.DateIn,
                Quantity = form.Quantity,
                VaccineId = form.VaccineId,
                CenterId = form.CenterId,
                WarehouseId = form.WarehouseId
            };
        }

        public Lot MapModelToEntity(LotModel model)
        {
            if (CheckIfNull(model)) return null;

            return new Lot {
                Id = model.Id,
                DateIn = model.DateIn,
                Quantity = model.Quantity,
                VaccineId = model.VaccineId,
                CenterId = model.CenterId,
                WarehouseId = model.WarehouseId
            };
        }

        public LotForm MapModelToForm(LotModel model)
        {
            if (CheckIfNull(model)) return null;

            return new LotForm
            {
                Id = model.Id,
                DateIn = model.DateIn,
                Quantity = model.Quantity,
                VaccineId = model.VaccineId,
                CenterId = model.CenterId,
                WarehouseId = model.WarehouseId
            };
        }
    }
}
