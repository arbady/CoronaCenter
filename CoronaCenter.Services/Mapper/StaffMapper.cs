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
    class StaffMapper : IMapper<Staff, StaffModel, StaffForm>
    {
        public StaffModel MapEntityToModel(Staff entity)
        {
            return new StaffModel { 
                Id = entity.Id,
                Grade = entity.Grade,
                Center = entity.Center,
                User = entity.User
            };
        }

        public Staff MapFormToEntity(StaffForm form)
        {
            return new Staff
            {
                Id = form.Id,
                Grade = form.Grade,
                Center = form.Center,
                User = form.User
            };
        }

        public Staff MapModelToEntity(StaffModel model)
        {
            return new Staff
            {
                Id = model.Id,
                Grade = model.Grade,
                Center = model.Center,
                User = model.User
            };
        }

        public StaffForm MapModelToForm(Staff model)
        {
            return new StaffForm
            {
                Id = model.Id,
                Grade = model.Grade,
                Center = model.Center,
                User = model.User
            };
        }
    }
}
