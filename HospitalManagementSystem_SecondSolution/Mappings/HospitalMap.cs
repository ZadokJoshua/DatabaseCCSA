using FluentNHibernate.Mapping;
using HospitalManagementSystem_SecondSolution.HospitalModel;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class HospitalMap : ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.HospitalId);
            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.Website);
            HasMany(x => x.Nurses);
            HasMany(x => x.Doctors);
            HasMany(x => x.Pharmacists);
            HasOne(x => x.Receptionist);
            HasOne(x => x.Accountant);
        }
    }
}
