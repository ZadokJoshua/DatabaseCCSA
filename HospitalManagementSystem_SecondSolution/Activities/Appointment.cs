using HospitalManagementSystem_SecondSolution.HospitalModel.Patient;
using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;

namespace HospitalManagementSystem_LiveEvaluation2.Activities
{
    public class Appointment
    {
        public virtual int AppointmentId { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Doctor? Doctor { get; set; }
        public virtual DateTime AppointmentTime { get; set; }

        public static decimal TotalBills = 0;

        //public virtual List<Condition> Condition { get; set; }
        //public virtual List<Drug> Drugs{ get; set; }

        IDictionary<string, decimal> billBreakdom = new Dictionary<string, decimal>();

        public void AddBill(string details, decimal payment)
        {
            billBreakdom.Add(details, payment);
            TotalBills += payment;
        }

        public void SubtractBill(string details)
        {
            if (billBreakdom.ContainsKey(details))
            {
                billBreakdom.Remove(details);
                Console.WriteLine("Removed - " + details);
            }
            else
            {
                Console.WriteLine("Didn't find - " + details);
            }
        }

        public decimal PrintBills()
        {
            return TotalBills;
        }

        public void AppointmentActivity()
        {
            //Console.WriteLine("Your condition - " + Condition);
            //Console.WriteLine("Drugs delivered - " + Drugs);

            // Print BillBreakdown
            foreach (KeyValuePair<string, decimal> kvp in billBreakdom)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine(TotalBills);
        }

    }
}
