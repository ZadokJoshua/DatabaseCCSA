using HospitalManagementSystem_LiveEvaluation2.Items;

namespace HospitalManagementSystem_SecondSolution.HospitalModel.Staffs
{
    public class Pharmacist : Staff
    {
        public virtual List<Drug> Drugs { get; set; }
    }
}
