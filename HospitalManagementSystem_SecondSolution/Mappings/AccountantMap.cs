using FluentNHibernate.Mapping;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class AccountantMap : ClassMap<Accountant>
    {
        public AccountantMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            References(x => x.Hospital);
        }
    }
}
