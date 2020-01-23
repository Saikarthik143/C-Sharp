using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduate
{
    class Istudent1
    {
        interface Ist
        {
              int Sid{ get; set; } 
            string name { get; set; }
            void showDetails();
        }
        class Resident:Istudent1
        {
            int sid;string name;
           // int Ist.Sid { get; set; }
           int Ist.Sid { get { return sid; } set { sid = value; } }
                string Ist.name { get { return name; } set { name = value; } }
        }
            public void showDetails()
            {
           
            Console.WriteLine();
            }

        }
}
