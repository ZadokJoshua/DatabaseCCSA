using FluentNHibernate.Mapping;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class DoctorsMap : ClassMap<Doctors>
    {
        public DoctorsMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            HasMany(x => x.Patients);
            HasMany(x => x.Nurses);
            References(x => x.Hospital);
        }
    }
}
