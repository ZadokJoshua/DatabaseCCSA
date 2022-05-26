using FluentNHibernate.Mapping;
using HospitalManagementSystem_LiveEvaluation2.Items;
using HospitalManagementSystem_LiveEvaluation2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Mappings
{
    public class DrugMap : ClassMap<Drug>
    {
        public DrugMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            HasManyToMany(x => x.Patients);
        }
    }
}
