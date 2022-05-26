using HospitalManagementSystem_LiveEvaluation2.Models;

namespace HospitalManagementSystem_LiveEvaluation2.Activities
{
    public class Activity
    {
        public virtual int Id { get; set; }
        public virtual Patients Patient { get; set; }
    }
}
