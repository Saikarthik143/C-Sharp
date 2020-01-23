using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass t = new ThreadClass();
            Thread th = new Thread(t.CountEven);
            Thread the = new Thread(t.Countodd);
            
            //the.Suspend();
            //th.Priority = ThreadPriority.Highest;
            //the.Priority = ThreadPriority.Highest;
            the.Start();
            th.Start();
        }
    }
}
