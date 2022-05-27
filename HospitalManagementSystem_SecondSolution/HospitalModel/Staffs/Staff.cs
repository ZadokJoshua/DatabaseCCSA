
namespace HospitalManagementSystem_SecondSolution.HospitalModel.Staffs
{
    public class Staff
    {
        public virtual int StaffId { get; set; }
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual string? Address { get; set; }
        public virtual int MobileNumber { get; set; }
        public virtual Hospital? Hospital { get; set; }
    }
}
