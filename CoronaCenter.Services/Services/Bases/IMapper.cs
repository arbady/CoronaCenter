using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public interface IMapper<Entity, Model, Form>
    {
        public Model MapEntityToModel(Entity entity);
        public Form MapModelToForm(Model model);
        public Entity MapFormToEntity(Form form);
        public Entity MapModelToEntity(Model model);
    }
}
