using CoronaCenter.Model.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoronaCenter.Model.Entities
{
    public class UserProfile : IDataModel<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        //[Column(TypeName = "VARBINARY(32)")]
        public byte[] Password { get; set; }
        public string Salt { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
    }
}