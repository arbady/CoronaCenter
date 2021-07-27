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
    public class VaccineMapper : BaseMapper, IMapper<Vaccine, VaccineModel, VaccineForm>
    {
        public VaccineModel MapEntityToModel(Vaccine entity)
        {
            if (CheckIfNull(entity)) return null;

            return new VaccineModel { 
                Id = entity.Id,
                Name = entity.Name,
                MinInterval = entity.MinInterval,
                MaxInterval = entity.MaxInterval,
                MakerId = entity.MakerId,
                Maker = entity.Maker
            };
        }

        public Vaccine MapFormToEntity(VaccineForm form)
        {
            if (CheckIfNull(form)) return null;

            return new Vaccine
            {
                Id = form.Id,
                Name = form.Name,
                MinInterval = form.MinInterval,
                MaxInterval = form.MaxInterval,
                MakerId = form.MakerId
            };
        }

        public Vaccine MapModelToEntity(VaccineModel model)
        {
            if (CheckIfNull(model)) return null;

            return new Vaccine {
                Id = model.Id,
                Name = model.Name,
                MinInterval = model.MinInterval,
                MaxInterval = model.MaxInterval,
                MakerId = model.MakerId
            };
        }

        public VaccineForm MapModelToForm(VaccineModel model)
        {
            if (CheckIfNull(model)) return null;

            return new VaccineForm
            {
                Id = model.Id,
                Name = model.Name,
                MinInterval = model.MinInterval,
                MaxInterval = model.MaxInterval,
                MakerId = model.MakerId
            };
        }
    }
}
