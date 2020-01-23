using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    abstract class DemoPoly
    {
        public abstract void Display();
        
            //Console.WriteLine("Display Parent:");
       
    }
    class b:DemoPoly
    {
        public  override void Display()
        {
            Console.WriteLine("Display child:");
        }

    }
    class c:DemoPoly
    {
        public override void Display()
        {
            Console.WriteLine("Display grand:");
        }

    }
}
