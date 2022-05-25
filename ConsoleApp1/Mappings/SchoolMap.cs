using DataConnections2.Models;
using FluentNHibernate.Mapping;

namespace DataConnections2.Mappings
{
    public class SchoolMap : ClassMap<School>
    {
        public SchoolMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.Students);
            HasMany(x => x.Teachers);
        }
    }
}
