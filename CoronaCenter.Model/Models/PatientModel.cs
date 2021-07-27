using CoronaCenter.Model.Entities;
using System;
using System.Collections.Generic;

namespace CoronaCenter.Model.Models
{
    public class PatientModel : IDataModel<int>
    {
        public int Id { get; set; }
        public string NISS { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string MedicalIndication { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public UserProfile User { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
    }
}
