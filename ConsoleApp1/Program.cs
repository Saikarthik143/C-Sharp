using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dsa =  DateTime.Now;
            Console.WriteLine(dsa.Month);
            Console.WriteLine(dsa.Day);
            Console.WriteLine(dsa.Year);
            Console.WriteLine(dsa.Hour);
            //dsa = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(dsa);
            dsa = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine(dsa);
            string s = Console.ReadLine();
            if (DateTime.TryParse(s, out dsa))
                Console.WriteLine(dsa);
            else
                Console.WriteLine("invalid date ");
        }
    }
}
