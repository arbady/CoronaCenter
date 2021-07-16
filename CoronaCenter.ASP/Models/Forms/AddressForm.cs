using CoronaCenter.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models.Forms
{
    public class AddressForm
    {
        public int Id { get; set; }
        
        [Required]
        [EnumDataType(typeof(Province))]
        public Province Province { get; set; }

        [Required]
        [MaxLength(64)]
        public string City { get; set; }

        [Required]
        [Range(1000, 9999)]
        public int ZipCode { get; set; }

        [Required]
        [MaxLength(64)]
        public string Street { get; set; }
        
        [Required]
        [MaxLength(16)]
        public string Number { get; set; }
    }
}
