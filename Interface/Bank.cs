using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Loan
        {
       void getInter();
    }
    interface Gloan : Loan
    {
        void getGoldINt();
    }
  public  abstract class Bank
    {
        protected string bname;
        protected string loca;
        public Bank(string name, string location)
        {
            this.bname = name;
            this.loca = location;
        }
       
    }
    public class SBI:Bank
    {
        string bMang;
        public SBI(string bname,string loca,string mang) : base(bname, loca)
        {
            this.bMang = mang;
        }
        public void getGoldINt()
        {
            Console.WriteLine("SBI Started bank loan");
        }
        public void getInter()
        {
            Console.WriteLine("Sbi loan Interest Rate at 7%");
        }
        public void Display()
        {
            Console.WriteLine("the name of the manager:" + this.bMang + "\n the name of the bank:" + this.bname + "\n the loaction:" + this.loca);
        }
    }
    public class HDFC : Bank,Loan
    {
        string bMang;
        public HDFC(string bname, string loca, string mang) : base(bname, loca)
        {
            this.bMang = mang;
        }
        public void getInter()
        {
            Console.WriteLine("HDFC loan Interest Rate at 10%");
        }
        public void Display()
        {
            Console.WriteLine("the name of the manager:" + this.bMang + "\n the name of the bank:" + this.bname + "\n the loaction:" + this.loca);
        }
    }
}
