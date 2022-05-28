using FluentNHibernate.Mapping;

namespace HospitalManagementSystem_LiveEvaluation2.Mappings
{
    public class DrugMap : ClassMap<Drug>
    {
        public DrugMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            HasManyToMany(x => x.Patients);
        }
    }
}
