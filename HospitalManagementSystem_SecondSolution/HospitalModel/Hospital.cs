using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;
using HospitalManagementSystem_SecondSolution.HospitalModel.Patient;
namespace HospitalManagementSystem_SecondSolution.HospitalModel;

public class Hospital
{
    public virtual int HospitalId { get; set; }
    public virtual string? Name { get; set; }
    public virtual string? Address { get; set; }
    public virtual string Website { get; set; }
    public virtual List<Nurse> Nurses { get; set; }
    public virtual List<Doctor> Doctors { get; set; }
    public virtual List<Pharmacist> Pharmacists { get; set; }
    public virtual Receptionist Receptionist { get; set; } // Ref
    public virtual Accountant Accountant { get; set; } // Ref
}
