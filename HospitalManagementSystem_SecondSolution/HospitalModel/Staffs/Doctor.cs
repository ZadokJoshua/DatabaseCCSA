using HospitalManagementSystem_SecondSolution.Items;

namespace HospitalManagementSystem_SecondSolution.HospitalModel.Staffs
{
    public class Doctor : Staff
    {
        public virtual Specialization Specialization { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
    }
}
