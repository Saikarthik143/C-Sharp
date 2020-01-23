using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dict
{
    class Program
    {
        public static void Read(string s, int f, int n)
        {
           
        }
        static void Main(string[] args)
        {
            int high = 0;
           
            /*dt.Add("sai", 22300);
            dt.Add("karthik", 32000);
            dt.Add("hai", 13000);*/
            int i,count;
            Console.WriteLine("enter the no of emp:");
            count = int.Parse(Console.ReadLine());
            Dictionary<string, int> dt = new Dictionary<string, int>();
            string name;
            int salary;
            for (i = 0; i < count; i++)
            {


                Console.WriteLine("enter the name:");

                name = Console.ReadLine();
                Console.WriteLine("enter the salary:");
                salary = Convert.ToInt32(Console.ReadLine());
                dt.Add(name, salary);
            }
            string hname="";
            foreach (KeyValuePair<string,int> h in dt)
            {
                if (h.Value > high)
                    high = h.Value;
                hname = h.Key;
            }
            Console.WriteLine("the highest paid:" + hname);
            
            
            
        }
    }
}
