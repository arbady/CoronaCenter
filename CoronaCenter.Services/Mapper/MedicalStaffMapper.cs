using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Enums;
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
    public class MedicalStaffMapper : IMapper<MedicalStaff, MedicalStaffModel, MedicalStaffForm>
    {
        public MedicalStaffModel MapEntityToModel(MedicalStaff entity)
        {
            return new MedicalStaffModel {
                Id = entity.Id,
                InamiNumber = entity.InamiNumber,
                Staff = entity.Staff
            };
        }

        public MedicalStaff MapFormToEntity(MedicalStaffForm form)
        {
            return new MedicalStaff
            {
                Id = form.Id,
                InamiNumber = form.InamiNumber,
                Staff = form.Staff
            };
        }

        public MedicalStaff MapModelToEntity(MedicalStaffModel model)
        {
            return new MedicalStaff
            {
                Id = model.Id,
                InamiNumber = model.InamiNumber,
                Staff = model.Staff
            };
        }

        public MedicalStaffForm MapModelToForm(MedicalStaffModel model)
        {
            return new MedicalStaffForm
            {
                Id = model.Id,
                InamiNumber = model.InamiNumber,
                Staff = model.Staff
            };
        }
    }
}
