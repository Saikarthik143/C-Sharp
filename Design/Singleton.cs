using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    class Singleton
    {
        static int count = 0;
        public static Singleton instance = null;//memory noyt allocated
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null) return new Singleton();
                else return instance;//existing instance memory
            }
        }
        private Singleton() {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            Console.WriteLine(s);
        }
    }
}
