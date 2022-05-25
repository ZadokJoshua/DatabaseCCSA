using DataConnections2.Models;
using FluentNHibernate.Mapping;

namespace DataConnections2.Mappings
{
    public class TeacherMap : ClassMap<Teacher>
    {
        public TeacherMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            References(x => x.School);
            HasManyToMany(x => x.Subjects);
        }
    }
}
