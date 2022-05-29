using FluentNHibernate.Mapping;
using HospitalManagementSystem_SecondSolution.HospitalModel.Patient;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class PatientsMap : ClassMap<Patient>
    {
        public PatientsMap()
        {
            Id(x => x.PatientId);
            Id(x => x.HospitalNumber);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            Map(x => x.MobileNo);
            Map(x => x.Age);
            Map(x => x.RegistrationStatus);
            References(x => x.Hospital);
            References(x => x.Doctor);
        }
    }
}
