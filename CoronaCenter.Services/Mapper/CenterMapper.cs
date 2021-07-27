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
    public class CenterMapper : BaseMapper, IMapper<Center, CenterModel, CenterForm>
    {
        public CenterModel MapEntityToModel(Center entity)
        {
            if (CheckIfNull(entity)) return null;

            StaffMapper sm = new StaffMapper();
            AddressMapper a = new AddressMapper();
            VaccineMapper v = new VaccineMapper();
            ScheduleMapper s = new ScheduleMapper();

            return new CenterModel {
                Id = entity.Id,
                Name = entity.Name,
                AddressId = entity.AddressId,
                Address = a.MapEntityToModel(entity.Address),
                ResponsibleId = entity.ResponsibleId,
                Responsible = sm.MapEntityToLiteModel(entity.Responsible),
                Vaccines = entity.Vaccines
                                 .Select(va => v.MapEntityToModel(va))
                                 .ToList(),

                Schedules = entity.Schedules
                                  .Select(se => s.MapEntityToModel(se))
                                  .ToList()
            };
        }

        public Center MapFormToEntity(CenterForm form)
        {
            if (CheckIfNull(form)) return null;

            return new Center
            {
                Id = form.Id,
                Name = form.Name,
                Address = form.Address,
                AddressId = form.AddressId,
                //Responsible = form.Responsible
            };
        }

        public Center MapModelToEntity(CenterModel model)
        {
            AddressMapper a = new AddressMapper();
            if (CheckIfNull(model)) return null;

            return new Center
            {
                Id = model.Id,
                Name = model.Name,
                AddressId = model.AddressId,
                Address = a.MapModelToEntity(model.Address)
                //ResponsibleId = model.ResponsibleId
            };
        }

        public CenterForm MapModelToForm(CenterModel model)
        {
            AddressMapper a = new AddressMapper();

            if (CheckIfNull(model)) return null;

            return new CenterForm
            {
                Id = model.Id,
                Name = model.Name,
                Address = a.MapModelToEntity(model.Address)
                //Responsible = model.Responsible
            };
        }
    }
}
