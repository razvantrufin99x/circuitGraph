using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitGraph
{
    public class ce
    {

        public ce() { }

        public int add( pin pi1,  pin pi2)
        {
            int r = 0;
            if (pi1.value == pi2.value && pi1.value == 1)
            {
                r = 1;
            }
            else
            {
                r = 0;
            }
        
            return r;
        }
           
    }
}
