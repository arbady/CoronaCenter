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
    public class CenterMapper : IMapper<Center, CenterModel, CenterForm>
    {
        public CenterModel MapEntityToModel(Center entity)
        {
            return new CenterModel {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                Responsible = entity.Responsible
            };
        }

        public Center MapFormToEntity(CenterForm form)
        {
            return new Center
            {
                Id = form.Id,
                Name = form.Name,
                Address = form.Address,
                Responsible = form.Responsible
            };
        }

        public Center MapModelToEntity(CenterModel model)
        {
            return new Center
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                Responsible = model.Responsible
            };
        }

        public CenterForm MapModelToForm(Center model)
        {
            return new CenterForm
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                Responsible = model.Responsible
            };
        }
    }
}
