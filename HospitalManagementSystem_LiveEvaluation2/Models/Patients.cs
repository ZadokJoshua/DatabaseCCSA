using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Patients : Human
    {
        public virtual int HospitalNumber { get; set; }
        public virtual Doctors Doctor { get; set; }
        public virtual DateTime AppointmentTime { get; set; }
    }
}
