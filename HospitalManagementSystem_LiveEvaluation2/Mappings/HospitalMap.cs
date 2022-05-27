using FluentNHibernate.Mapping;

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
            References(x => x.Accountant);
        }
    }
}
