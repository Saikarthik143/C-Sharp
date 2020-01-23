using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigndSma
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int high, small;
            Console.WriteLine("enter the size :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[n];
                        for (int i = 0; i < n; i++)
            {
               s[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("the  no's:" + s[i]);
            }
            high = s[0];
            small = s[0];
            for (int i = 0; i < n; i++)
            {
              if(s[i]>high)
                {
                    high = s[i];
                }
              if(s[i]<small)
                {
                    small = s[i];
                }
                
               
            }
            Console.WriteLine("the highest num:" +"\t" + high + "the smallest num:" + small);


        }
    }
}
