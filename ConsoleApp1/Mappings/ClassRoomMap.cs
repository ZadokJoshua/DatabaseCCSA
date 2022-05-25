using DataConnections2.Models;
using FluentNHibernate.Mapping;

namespace DataConnections2.Mappings
{
    public class ClassRoomMap : ClassMap<ClassRoom>
    {
        public ClassRoomMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Students);
            HasOne(x => x.Teacher);
        }
    }
}
