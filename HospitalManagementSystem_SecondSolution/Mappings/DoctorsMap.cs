using FluentNHibernate.Mapping;
using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class DoctorsMap : ClassMap<Doctor>
    {
        public DoctorsMap()
        {
            Id(x => x.StaffId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            Map(x => x.MobileNumber);
            References(x => x.Hospital);
            Map(x => x.Specialization);
        }
    }
}
