using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class UnregisteredPatientsMap : ClassMap<UnregisteredPatients>
    {
        public UnregisteredPatientsMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            Map(x => x.Age);
            HasOne(x => x.HospitalNumber);
            HasOne(x => x.Doctor);
            References(x => x.Doctor);
        }
    }
}
