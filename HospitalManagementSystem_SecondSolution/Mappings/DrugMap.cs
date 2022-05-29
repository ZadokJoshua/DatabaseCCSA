using FluentNHibernate.Mapping;
using HospitalManagementSystem_LiveEvaluation2.Items;

namespace HospitalManagementSystem_LiveEvaluation2.Mappings
{
    public class DrugMap : ClassMap<Drug>
    {
        public DrugMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            References(x => x.Pharmacist);
        }
    }
}
