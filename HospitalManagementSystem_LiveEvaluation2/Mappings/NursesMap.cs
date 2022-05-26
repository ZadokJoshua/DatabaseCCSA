using FluentNHibernate.Mapping;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class NursesMap : ClassMap<Nurses>
    {
        public NursesMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            HasOne(x => x.Doctor);
        }
    }
}
