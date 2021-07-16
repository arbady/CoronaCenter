using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Models
{
    public class VaccineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinInterval { get; set; }
        public int MaxInterval { get; set; }
        public int MakerId { get; set; }
    }
}
