using CoronaCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public interface IService<Model, Form>
    {
        public IEnumerable<Model> GetAll();
        public Model GetById(int id);
        public Form Update(int id, Form form);
        public Model Insert(Form form);
        public void Delete(int id);
    }
}
