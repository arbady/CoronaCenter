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
    public class MakerMapper : IMapper<Maker, MakerModel, MakerForm>
    {
        public MakerModel MapEntityToModel(Maker entity)
        {
            return new MakerModel {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public Maker MapFormToEntity(MakerForm form)
        {
            return new Maker { 
                Id = form.Id,
                Name = form.Name
            };
        }

        public Maker MapModelToEntity(MakerModel model)
        {
            return new MakerModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public MakerForm MapModelToForm(MakerModel entity)
        {
            return new MakerForm
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
