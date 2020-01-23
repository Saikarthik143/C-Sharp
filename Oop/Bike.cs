using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Bike
    {
        string name;
        string clr;
        
        public void StartEngine()
        {
            Console.WriteLine("Bike Started at" +"\t"+ DateTime.Now.Hour);
        }
        public void FillGas(int lit)
        {
            Console.WriteLine("Filled with" + "\t" + lit + "litres");
        }
        public int Distance(int d,int s)
        {
            int t;
            t = 
                d / s;
            Console.WriteLine("you will reach at"+ "\t"+t);
            return t;
        }


    }
}
