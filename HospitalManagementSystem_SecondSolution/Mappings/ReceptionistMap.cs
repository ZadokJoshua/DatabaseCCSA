using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class ReceptionistMap : ClassMap<Receptionist>
    {
        public ReceptionistMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            HasMany(x => x.Patient);
            HasOne(x => x.Hospital);
        }
    }
}
