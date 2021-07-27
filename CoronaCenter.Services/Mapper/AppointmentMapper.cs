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
    public class AppointmentMapper : BaseMapper, IMapper<Appointment, AppointmentModel, AppointmentForm>
    {
        public AppointmentModel MapEntityToModel(Appointment entity)
        {
            if (CheckIfNull(entity)) return null;

            return new AppointmentModel{
                Id = entity.Id,
                DateVacc = entity.DateVacc,
                HoursVacc = entity.HoursVacc,
                PatientId = entity.PatientId,
                CenterId = entity.CenterId,
                VaccineId = entity.VaccineId,
                Patient = entity.Patient,
                Center = entity.Center,
                Vaccine = entity.Vaccine,
                Vaccinations = entity.Vaccinations
            };
        }

        public Appointment MapFormToEntity(AppointmentForm form)
        {
            return new Appointment
            {
                Id = form.Id,
                DateVacc = form.DateVacc,
                HoursVacc = form.HoursVacc,
                PatientId = form.PatientId,
                CenterId = form.CenterId,
                VaccineId = form.VaccineId
            };
        }

        public Appointment MapModelToEntity(AppointmentModel model)
        {
            return new Appointment{
                Id = model.Id,
                DateVacc = model.DateVacc,
                HoursVacc = model.HoursVacc,
                PatientId = model.PatientId,
                CenterId = model.CenterId,
                VaccineId = model.VaccineId,
                Patient = model.Patient,
                Center = model.Center,
                Vaccine = model.Vaccine,
                Vaccinations = model.Vaccinations
            };
        }

        public AppointmentForm MapModelToForm(AppointmentModel model)
        {
            return new AppointmentForm
            {
                Id = model.Id,
                DateVacc = model.DateVacc,
                HoursVacc = model.HoursVacc,
                PatientId = model.PatientId,
                CenterId = model.CenterId,
                VaccineId = model.VaccineId
            };
        }
    }
}
