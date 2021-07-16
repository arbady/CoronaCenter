using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Models
{
    public interface IDataModel<Tid>
    {
        public Tid Id { get; }

    }
}
