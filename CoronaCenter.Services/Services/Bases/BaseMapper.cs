using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public abstract class BaseMapper
    {
        protected bool CheckIfNull(object entity)
        {
            return entity is null;
        }
    }
}
