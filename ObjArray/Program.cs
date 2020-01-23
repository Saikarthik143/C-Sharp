using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Train> elist = new List<Train>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the user name");
                string s = Console.ReadLine();
                Console.WriteLine("enter the trainee id:");
                int tr = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the pro id:");
                int pr = Convert.ToInt32(Console.ReadLine());


                elist.Add(new Train(s, tr, pr));
            }
            
            List<Train> high = elist.FindAll(e => e.pid== -1);
            foreach(Train el in high)
            {
                Console.WriteLine(el.ToString());
            }
        }
    }
}
