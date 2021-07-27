using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoronaCenter.Model.Models
{
    public class AddressModel : IDataModel<int>
    {
        public int Id { get; set; }
        public Province Province { get; set; }
        public string City { get; set; }

        [Range(1000, 9999)]
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
