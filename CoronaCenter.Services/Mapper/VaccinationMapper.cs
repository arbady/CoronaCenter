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
    public class VaccinationMapper : IMapper<Vaccination, VaccinationModel, VaccinationForm>
    {
        public VaccinationModel MapEntityToModel(Vaccination entity)
        {
            return new VaccinationModel
            {
                Id = entity.Id,
                MedicalStaffId = entity.MedicalStaffId,
                LotId = entity.LotId,
                AppointmentId = entity.AppointmentId
            };
        }

        public Vaccination MapFormToEntity(VaccinationForm form)
        {
            return new Vaccination
            {
                Id = form.Id,
                MedicalStaffId = form.MedicalStaffId,
                LotId = form.LotId,
                AppointmentId = form.AppointmentId
            };
        }

        public Vaccination MapModelToEntity(VaccinationModel model)
        {
            return new Vaccination {
                Id = model.Id,
                MedicalStaffId = model.MedicalStaffId,
                LotId = model.LotId,
                AppointmentId = model.AppointmentId
            };
        }

        public VaccinationForm MapModelToForm(VaccinationModel model)
        {
            return new VaccinationForm
            {
                Id = model.Id,
                MedicalStaffId = model.MedicalStaffId,
                LotId = model.LotId,
                AppointmentId = model.AppointmentId
            };
        }
    }
}
