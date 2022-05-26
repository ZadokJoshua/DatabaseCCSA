using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Nurses : Human
    {
        public virtual Doctors Doctors { get; set; }
    }
}
