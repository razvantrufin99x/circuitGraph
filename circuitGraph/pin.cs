using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitGraph
{
    public class pin
    {
        public int codpin;
        public int value;
        public pin() { }
        public pin(int pcodpin, int pvalue) {
            this.codpin = pcodpin;
            this.value = pvalue;
        }
    }
}
