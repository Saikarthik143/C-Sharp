using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjArray
{
   public class Train
    {
       public int trid,pid;
        string train_name;
        public Train()
        {

        }
        public Train(string name, int trid, int pid)
        {
            this.train_name = name;
            this.trid = trid;

            this.pid = pid;

        }

              public int Trid { get => trid; set => trid = value; }
        public int Pid { get => pid; set => pid = value; }
        public string Train_name { get => train_name; set => train_name = value; }

        public override string ToString()
        {
            return this.train_name;     }

    }
}
