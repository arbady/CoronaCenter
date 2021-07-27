using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public interface IBase<Entity, Model, Form> : IService<Entity, Model, Form, int>{}
}
