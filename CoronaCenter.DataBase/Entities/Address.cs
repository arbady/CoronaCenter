using CoronaCenter.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class Address : IDataModel<int>
    {
        public int Id { get; set; }

        [EnumDataType(typeof(Province))]
        public Province Province { get; set; }
        public string City { get; set; }

        [Range(1000, 9999)]
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
