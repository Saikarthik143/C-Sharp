using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /*int amo;
            string tp;
            Console.WriteLine("enter the available balance:");
            amo = Convert.ToInt32(Console.ReadLine());
            */
            Console.WriteLine("enter the account number:");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name:");
            string s = Console.ReadLine();
            Console.WriteLine("enter the account type");
            string aty = Console.ReadLine();
            Console.WriteLine("enter the number:");
            int bal = Convert.ToInt32(Console.ReadLine());

            Account a = new Account(ano,s,aty,bal);
            Console.WriteLine("enter the transaction type (d/w):");

            string tp = Console.ReadLine();
            if (tp == "d" || tp == "D")
            {
                Console.WriteLine("Enter the amount to deposit");
                int amt = Convert.ToInt32(Console.ReadLine());
                a.Credit(amt);
            }
            else if (tp == "w" || tp == "W")
            {
                Console.WriteLine("Enter the amount to withdraw");
                int amt1 = Convert.ToInt32(Console.ReadLine());
                a.Debit(amt1);
            }
            else
                Console.WriteLine("invalid");
            a.display();








        }
    }
}
