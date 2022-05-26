using HospitalManagementSystem_LiveEvaluation2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Items
{
    public class Condition
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Patients> Patients{ get; set; }
    }
}
