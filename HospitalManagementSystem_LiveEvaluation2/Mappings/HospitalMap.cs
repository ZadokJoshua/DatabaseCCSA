using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class HospitalMap : ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.Nurses);
            HasMany(x => x.Patients);
            HasMany(x => x.Doctors);
            HasMany(x => x.Pharmacists);
            HasOne(x => x.Receptionist);
            HasOne(x => x.Accountant);
        }
    }
}
