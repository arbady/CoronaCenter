using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;

namespace CoronaCenter.Model.Entities
{
    public class Patient : IDataModel<int>
    {
        public int Id { get; set; }
        public string NISS { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string MedicalIndication { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual IEnumerable<Appointment> Appointments { get; set; }
    }
}
