using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_LiveEvaluation2.Activities
{
    public class Billing : Activity
    {
        public static decimal TotalBills = 0;
        

        public void AddBill(int payment)
        {
            TotalBills += payment;
        }


        public void SubtractBill(int payment)
        {
            if(TotalBills <= 0)
            {
                Console.WriteLine("You are yet to place an order.");
            }
            else
            {
                TotalBills -= payment;
            }
        }

        public decimal PrintBills()
        {
            return TotalBills;
        }
    }
}
