using HospitalManagementSystem_LiveEvaluation2.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Models
{
    public class Patients : Human
    {
        Receptionist receptionist = new Receptionist();

        public virtual int Age { get; set; }
        public virtual int HospitalNumber { get; set; }
        public virtual Doctors Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }



        public virtual void BookAppointment(Patients patients)
        {
            if (receptionist.CheckPatientStatus(patients) is true)
            {
                var appointment = new Appointment();
                appointment.AppointmentActivity(); 
            }
            else
            {

            }
        }
    }
}
