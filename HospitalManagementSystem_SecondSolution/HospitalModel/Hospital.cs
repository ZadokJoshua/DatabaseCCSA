using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;
namespace HospitalManagementSystem_SecondSolution.HospitalModel;

public class Hospital
{
    public virtual int HospitalId { get; set; }
    public virtual string? Name { get; set; }
    public virtual string? Address { get; set; }
    public virtual int Email { get; set; }
    public virtual Receptionist Receptionist { get; set; } // Ref
    public virtual Accountant Accountant { get; set; } // Ref
}
