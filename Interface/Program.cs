using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            SBI s = new SBI("SBI 000", "eluru", "Hari");
            s.Display();
            s.getInter();
            s.getGoldINt();

            HDFC h = new HDFC("hdfc 007", "hyd", "karthik");
            h.getInter();
            h.Display();
        }
    }
}
