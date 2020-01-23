using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur choice:\n 1:Cricket \n 2:hockey ");
            int n= int.Parse(Console.ReadLine());
            if (n == 1)
            {


                Console.WriteLine("enter a player name");
                string na = Console.ReadLine();
                Console.WriteLine("enter a player country");
                string na1 = Console.ReadLine();
                Console.WriteLine("enter a player matches");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a player score ");
                int s = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a player wickets ");
                int s1 = int.Parse(Console.ReadLine());
                Cricket sai = new Cricket(na, na1, m, s, s1);
                sai.DisplayPlayerStatistics();
                Console.WriteLine();
            }
            else if (n == 2)
            {

                Console.WriteLine("enter a player name");
                string na = Console.ReadLine();
                Console.WriteLine("enter a player country");
                string na1 = Console.ReadLine();
                Console.WriteLine("enter a player matches");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a player position");
                string s = Console.ReadLine();
                Console.WriteLine("enter a player goals ");
                int s1 = int.Parse(Console.ReadLine());
                Hockey a = new Hockey(na, na1, m, s, s1);
                a.DisplayPlayerStatistics();
            }
            else
                Console.WriteLine("invalid");
        }
    }
}
