namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Nurses : Human
    {
        public virtual Doctors Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
