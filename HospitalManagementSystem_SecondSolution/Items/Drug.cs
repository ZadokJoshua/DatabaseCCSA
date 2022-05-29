using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;

namespace HospitalManagementSystem_LiveEvaluation2.Items
{
    public class Drug
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Pharmacist Pharmacist { get; set; }
    }
}
