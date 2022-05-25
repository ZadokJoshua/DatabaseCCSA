using DataConnections2.Models;
using FluentNHibernate.Mapping;

namespace DataConnections2.Mappings
{
    public class SubjectsMap : ClassMap<Subjects>
    {
        public SubjectsMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x => x.Teacher);
        }
    }
}
