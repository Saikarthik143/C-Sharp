using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Delivery
    {
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("enter the name of the bowler: " + bowler+"\n");
            Console.WriteLine("enter the name of the batsman: " + batsman);
        }
        public void DisplayDeliveryDetails(int runs)
        {
            int[] arr = new int[6];
            
            int m;
            m = runs;


            if (m == 6)
            
                Console.WriteLine("it is a Six:" + m + "\n");
            
               else if (m == 4)
                {
                    Console.WriteLine("it is a four:" + m);
                }
                else
                    Console.WriteLine("number of runs:" + m);
            
        }

    }
}
