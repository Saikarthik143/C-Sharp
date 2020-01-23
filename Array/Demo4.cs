using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Demo4
    {
        static void Main()
        {
            string[] name = new string[8]
            {
                "Sai",
                "Karthik",
                "Rahil",
                "hari",
                "Suresh",
                "Dhoni",
                "Ravi",
                "Gir"
            };
            Console.WriteLine("enter a name:");
            string r = Console.ReadLine();
            int m = 0;
            foreach (string i in name)
            {
                if (i == r)
                {
                    //Console.WriteLine(i+"is present");
                    m = 1;
                    break;
                }
                
            }
            if(m==1)
            Console.WriteLine(" found:");
            else
                Console.WriteLine("not found:");


        }
    }
}
