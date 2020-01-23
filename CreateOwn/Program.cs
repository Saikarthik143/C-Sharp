using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOwn
{
   
    class Program
    {
        
        static void Main(string[] args) {
            Train t = new Train();

            
            try
            {
                if (t > 2)
                    throw new ticketBooking("cannot boook more than 2 tickets:");
                else
                    Console.WriteLine("the tickets are booked");

                /*Employee emp = new Employee();
                try
                {
                    if (emp.Sal == 0) throw new salaryException("salary cannot be zero");

                }
                catch(salaryException e)
                {
                    Console.WriteLine(e.Message + " ");
                }*/
            }
    }
}
