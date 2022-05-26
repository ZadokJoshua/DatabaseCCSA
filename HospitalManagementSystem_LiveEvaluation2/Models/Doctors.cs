using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Doctors : Human
    {
        public virtual List<Patients> Patients { get; set; }
        public virtual List<Nurses> Nurses { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
