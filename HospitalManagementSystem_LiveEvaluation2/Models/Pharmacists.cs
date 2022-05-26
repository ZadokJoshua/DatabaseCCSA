using HospitalManagementSystem_LiveEvaluation2.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Pharmacists : Human
    {
        // public virtual List<Drug> Drugs { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
