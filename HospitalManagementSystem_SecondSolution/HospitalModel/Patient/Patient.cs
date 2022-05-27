using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_SecondSolution.HospitalModel.Patient
{
    public class Patient
    {
        public virtual int PatientId { get; set; }
        public virtual int HospitalNumber { get; set; }
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual string? Address { get; set; }
        public virtual int Mobile_No { get; set; }
        public virtual int Age { get; set; }
        public virtual bool RegistrationStatus { get; set; }
        public virtual Hospital? Hospital { get; set; }
    }
}
