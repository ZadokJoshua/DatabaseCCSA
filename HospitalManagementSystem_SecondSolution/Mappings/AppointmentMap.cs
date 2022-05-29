using FluentNHibernate.Mapping;
using HospitalManagementSystem_LiveEvaluation2.Activities;

namespace HospitalManagementSystem_SecondSolution.Mappings
{
    public class AppointmentMap : ClassMap<Appointment>
    {
        public AppointmentMap()
        {
            Id(x => x.AppointmentId);
            References(x => x.Patient);
            References(x => x.Doctor);
            Map(x => x.AppointmentTime);
            Map(x => x.Condition);
        }
    }
}
