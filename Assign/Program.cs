using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the size:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("please enteer odd num:");

                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter a num:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            

                if (n == 1)
                {
                    Console.WriteLine("the highest num:" + n);
                }
                else
                {
                   
                        int start = arr[0], mid = arr[n / 2], last = arr[n - 1];
                        if ((start > mid) && (start>last))
                        
                          

                                Console.WriteLine("the largest num is first:" + start);

                           
                            
                                else if (mid > last)

                                    Console.WriteLine("the middle is highest:" + mid);

                                else
                                    Console.WriteLine("the last is highest:" + last);

                            
                        
                    
                
               
            }
        }
    }
}
