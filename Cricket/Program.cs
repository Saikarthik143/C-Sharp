using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu \n 1:Player details of the delivery \n 2:run details of the delivery");
            Console.WriteLine("enter your choice:");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("enter the bowler name:");
                string na = Console.ReadLine();
                Console.WriteLine("enter the batsman name:");
                string ba = Console.ReadLine();
                Delivery obj = new Delivery();
                obj.DisplayDeliveryDetails(na, ba);
                Console.WriteLine();

            }
            else if (n == 2)
            {
                Console.WriteLine("enter the runs:");
                int run = int.Parse(Console.ReadLine());
                Delivery obj1 = new Delivery();
                obj1.DisplayDeliveryDetails(run);
            }
        }
    }
}
