using HospitalManagementSystem_LiveEvaluation2.Items;
using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;

namespace HospitalManagementSystem_SecondSolution.HospitalModel.Patient
{
    public class Patient
    {
        public virtual int PatientId { get; set; }
        public virtual int HospitalNumber { get; set; }
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual string? Address { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual int Mobile_No { get; set; }
        public virtual int Age { get; set; }
        public virtual bool RegistrationStatus { get; set; }
        public virtual Hospital? Hospital { get; set; }
        public virtual Doctor? Doctor { get; set; }
    }
}
