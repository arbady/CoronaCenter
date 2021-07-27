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
    public class ScheduleMapper : BaseMapper, IMapper<Schedule, ScheduleModel, ScheduleForm>
    {
        public ScheduleModel MapEntityToModel(Schedule entity)
        {
            if (CheckIfNull(entity)) return null; 

            return new ScheduleModel
            {
                Id = entity.Id,
                Day = entity.Day,
                OpenHours = entity.OpenHours,
                CloseHours = entity.CloseHours,
                CenterId = entity.CenterId, 
                //Center = entity.Center
            };
        }

        public Schedule MapFormToEntity(ScheduleForm form)
        {
            if (CheckIfNull(form)) return null;

            return new Schedule
            {
                Id = form.Id,
                Day = form.Day,
                OpenHours = form.OpenHours,
                CloseHours = form.CloseHours,
                CenterId = form.CenterId
            };
        }

        public Schedule MapModelToEntity(ScheduleModel model)
        {
            if (CheckIfNull(model)) return null;

            return new Schedule {
                Id = model.Id,
                Day = model.Day,
                OpenHours = model.OpenHours,
                CloseHours = model.CloseHours,
                CenterId = model.CenterId
            };
        }

        public ScheduleForm MapModelToForm(ScheduleModel model)
        {
            if (CheckIfNull(model)) return null;

            return new ScheduleForm
            {
                Id = model.Id,
                Day = model.Day,
                OpenHours = model.OpenHours,
                CloseHours = model.CloseHours,
                CenterId = model.CenterId
            };
        }
    }
}
