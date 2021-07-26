using CoronaCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public interface IService<Model, Form, Tid>
    {
        public IEnumerable<Model> GetAll();
        public Model GetById(Tid id);
        public Form GetToForm(Tid id);
        public Form Update(Tid id, Form form);
        public Model Insert(Form form);
        public void Delete(Tid id);
        public bool Has(Tid id);
        public bool Has(Model Model);
        public bool Has(Form form);
    }
}
