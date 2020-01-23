using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc
{
    class Account
    {
        static string bname = "sbi";
        int acno;
        string name;
        int amount;
        int bal;
        string acctype;
        string transtype;

       public int Acno { get => acno; set => acno = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Bal { get => bal; set => bal = value; }
        public string Acctype { get => acctype; set => acctype = value; }
        public string Transtype { get => transtype; set => transtype = value; }

        public Account() { }
        public void Debit(int amt)
        {
            this.transtype = "W";
            Amount -= amt;
            //Console.WriteLine("the money left after withdraw:" + Amount);
        }
        public void Credit(int at)
        {
            this.transtype = "D";
            Amount += at;
            //Console.WriteLine("the money left after deposit:" + Amount);
        }
        public Account(int no, string n, string a,int amo)
        {
            this.acno = no;
            this.Name = n;
            this.Acctype = a;
            this.amount = amo;
            
        }

        public void display() { 
            Console.WriteLine(bname+ "  " +
                ""+this.acno + "\t" + this.name + "\t" + this.acctype+"\t"+this.Amount);
        }
       
    }
}
