using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class PharmacistsMap : ClassMap<Pharmacists>
    {
        public PharmacistsMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            References(x => x.Hospital);
        }
    }
}
