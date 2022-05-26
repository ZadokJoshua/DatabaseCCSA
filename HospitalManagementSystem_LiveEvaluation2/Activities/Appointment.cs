using HospitalManagementSystem_LiveEvaluation2.Models;

namespace HospitalManagementSystem_LiveEvaluation2.Activities
{
    public class Appointment : Activity
    {
        public virtual Doctors Doctor { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual string Condition { get; set; }

    }
}
