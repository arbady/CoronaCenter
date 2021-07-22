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
            };

            //return (PatientModel)entity;
        }

        public Patient MapFormToEntity(PatientForm form)
        {
            throw new System.NotImplementedException();
        }

        public Patient MapModelToEntity(PatientModel model)
        {
            throw new System.NotImplementedException();
        }

        public PatientForm MapModelToForm(Patient entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
