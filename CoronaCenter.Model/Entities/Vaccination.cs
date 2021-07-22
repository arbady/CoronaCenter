namespace CoronaCenter.Model.Entities
{
    public class Vaccination : IDataModel<int>
    {
        public int Id { get; set; }
        public int MedicalStaffId { get; set; }
        public int LotId { get; set; }
        public int AppointmentId { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual Lot Lot { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
