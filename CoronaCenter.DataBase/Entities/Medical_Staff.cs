using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Medical_Staff : IDataModel<int>
    {
        public int Id { get; set; }
        public string InamiNumber { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual IEnumerable<Vaccination> Vaccinations { get; set; }
    }
}
