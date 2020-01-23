using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        public static void Name(string x)
        {
            Console.WriteLine("the  user name is:"+x);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Name(s);

        }
    }
}
