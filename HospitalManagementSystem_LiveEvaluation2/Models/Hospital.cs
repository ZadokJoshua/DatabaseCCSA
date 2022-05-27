using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Hospital
    {
        // Properties
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual List<Nurses> Nurses { get; set; }
        public virtual List<Patients> Patients { get; set; }
        public virtual List<Doctors> Doctors { get; set; }
        public virtual List<Pharmacists> Pharmacists { get; set; }
        public virtual Receptionist Receptionist { get; set; }
        public virtual Accountant Accountant { get; set; }


    }
}
