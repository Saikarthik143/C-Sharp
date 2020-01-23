using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread
{
    class ThreadClass
    {
        public void CountEven() {
            lock (this)
            {
                for (int i = 0; i < 100; i+=2)
                {

                    Console.WriteLine(i);
                    //if (i == 50) Thread.Sleep(1000);     
                }
            }
        }
        public void Countodd()
        {
            for(int i=1;i<100;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
            

    }

