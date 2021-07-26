using CoronaCenter.DataBase;
using CoronaCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public abstract class BaseProvider<Entity, Model, Form> : 
        BaseServices<DataContext, Entity, Model, Form, int>,
        IBase<Model, Form>
        where Entity : class, IDataModel<int> 
    {
        protected BaseProvider(DataContext dc, IMapper<Entity, Model, Form> mapper) : base(dc, mapper)
        {
        }
    }
}
