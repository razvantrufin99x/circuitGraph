using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitGraph
{
    public class wire
    {
        public int codwire;
        public pin pinInput;
        public pin pinOutput;
        public wire() { }
        public wire(int pcodwire) { this.codwire = pcodwire; }
        public wire(int pcodwire, pin ppi, pin ppo) { 
            this.codwire = pcodwire; 
            this.pinOutput = ppi;
            this.pinInput = ppo;
        }
    }
}
