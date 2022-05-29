using FluentNHibernate.Mapping;
using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class NursesMap : ClassMap<Nurse>
    {
        public NursesMap()
        {
            Id(x => x.StaffId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            Map(x => x.MobileNumber);
            References(x => x.Hospital);
            References(x => x.Doctor);
        }
    }
}
