using FluentNHibernate.Mapping;
using HospitalManagementSystem_LiveEvaluation2.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Mappings
{
    public class ConditionMap : ClassMap<Condition>
    {
        public ConditionMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x => x.Patients);
        }
    }
}
