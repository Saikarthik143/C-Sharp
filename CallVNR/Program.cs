using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallVNR
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            Console.WriteLine("enter the two values:");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
           int res= c.Add(n, a);
            Console.WriteLine(res);
            c.Subtract(n, a, out int sub);
            c.Swap(ref n, ref a,out int z,out int y);
            
            Console.WriteLine(sub);
            Console.WriteLine(z +" " +y);

        }
    }
}
