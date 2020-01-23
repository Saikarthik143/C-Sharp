using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Child ch = new Child();
             Parent p = new Parent();
             Grand g = new Grand();
             demo.ExChhild e = new demo.ExChhild();

             p.getValue(4, "karthu");
             p.display();
             ch.getValue(3, "hello");
             ch.display();
             ch.Calculate(50);
             g.add(18);
             e.ExDisplay();*/
           // vehicle v = new vehicle();
            car bmw = new car();
            bus rtc = new bus();
           // v.Start();
            car ns = new car(" blue", 50);
            ns.drive();
            rtc.Run();
            bmw.Stop();
            bmw.drive();
            bmw.fill();
            rtc.fill();
            bmw.Start();
        }
    }
}
