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
    public class WarehouseMapper : IMapper<Warehouse, WarehouseModel, WarehouseForm>
    {
        public WarehouseModel MapEntityToModel(Warehouse entity)
        {
            return new WarehouseModel
            {
                Id = entity.Id,
                Name = entity.Name,
                AddressId = entity.AddressId
            };
        }

        public Warehouse MapFormToEntity(WarehouseForm form)
        {
            return new Warehouse
            {
                Id = form.Id,
                Name = form.Name,
                AddressId = form.AddressId
            };
        }

        public Warehouse MapModelToEntity(WarehouseModel model)
        {
            return new Warehouse {
                Id = model.Id,
                Name = model.Name,
                AddressId = model.AddressId
            };
        }

        public WarehouseForm MapModelToForm(WarehouseModel model)
        {
            return new WarehouseForm
            {
                Id = model.Id,
                Name = model.Name,
                AddressId = model.AddressId
            };
        }
    }
}
