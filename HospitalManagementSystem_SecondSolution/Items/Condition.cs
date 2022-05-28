using HospitalManagementSystem_SecondSolution.HospitalModel.Patient;

namespace HospitalManagementSystem_LiveEvaluation2.Items
{
    public class Condition
    {
        public virtual int Id { get; set; }
        public virtual string Details { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
