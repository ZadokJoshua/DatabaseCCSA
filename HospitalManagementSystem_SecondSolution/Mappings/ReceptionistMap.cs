using FluentNHibernate.Mapping;
using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class ReceptionistMap : ClassMap<Receptionist>
    {
        public ReceptionistMap()
        {
            Id(x => x.StaffId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            Map(x => x.MobileNumber);
            References(x => x.Hospital);
        }
    }
}
