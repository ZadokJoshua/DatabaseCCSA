namespace HospitalManagementSystem_SecondSolution.HospitalModel.Staffs
{
    public class Nurse : Staff
    {
        public virtual Doctor? Doctor { get; set; }
    }
}
