using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Receptionist : Human
    {
        public virtual List<Patients> Patient { get; set; }
        public virtual Hospital Hospital { get; set; }

        public virtual bool CheckPatientStatus(Patients patients)
        {
            if (Patient is RegisteredPatients)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please go and register Sir/Ma");
                return false;
            }
        }
    }
}
