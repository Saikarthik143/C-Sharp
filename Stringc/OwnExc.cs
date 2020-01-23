using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringc
{
    class OwnExc
    {
        public class Salaray:Exception
        {
            public Salaray(string s) : base(s)
            {

            }
        }
        
    }
}
