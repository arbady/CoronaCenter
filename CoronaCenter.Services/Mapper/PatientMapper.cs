using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services.Bases;

namespace CoronaCenter.Services.Mapper
{
    public class PatientMapper : IMapper<Patient, PatientModel, PatientForm>
    {
        public PatientModel MapEntityToModel(Patient entity)
        {
            return new PatientModel
            {
                Id = entity.Id,
                NISS = entity.NISS,
                DateOfBirth = entity.DateOfBirth,
                PhoneNumber = entity.PhoneNumber,
                MedicalIndication = entity.MedicalIndication,
                Address = entity.Address,
                User = entity.User
            };

            //return (PatientModel)entity;
        }

        public Patient MapFormToEntity(PatientForm form)
        {
            return new Patient
            {
                Id = form.Id,
                NISS = form.NISS,
                DateOfBirth = form.DateOfBirth,
                PhoneNumber = form.PhoneNumber,
                MedicalIndication = form.MedicalIndication,
                Address = form.Address,
                User = form.User
            };
        }

        public Patient MapModelToEntity(PatientModel model)
        {
            return new Patient
            {
                Id = model.Id,
                NISS = model.NISS,
                DateOfBirth = model.DateOfBirth,
                PhoneNumber = model.PhoneNumber,
                MedicalIndication = model.MedicalIndication,
                Address = model.Address,
                User = model.User
            };
        }

        public PatientForm MapModelToForm(PatientModel model)
        {
            return new PatientForm
            {
                Id = model.Id,
                NISS = model.NISS,
                DateOfBirth = model.DateOfBirth,
                PhoneNumber = model.PhoneNumber,
                MedicalIndication = model.MedicalIndication,
                Address = model.Address,
                User = model.User
            };
        }
    }
}
