using DataConnections2.Models;
using FluentNHibernate.Mapping;

namespace DataConnections2.Mappings
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            HasMany(x => x.Subjects);
            HasOne(x => x.F);
        }
    }
}
