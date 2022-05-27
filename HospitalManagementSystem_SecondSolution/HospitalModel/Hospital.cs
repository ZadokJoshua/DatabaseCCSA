namespace HospitalManagementSystem_SecondSolution.HospitalModel
{
    public class Hospital
    {
        public virtual int HospitalId { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Address { get; set; }
        public virtual int Email { get; set; }
    }
}
