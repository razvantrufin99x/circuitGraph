using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitGraph
{
    public class device
    {
        public int coddevice;
        public List<pin> pinInput = new List<pin>();
        public List<pin> pinOutput = new List<pin>();
        public device() { }
        public device(int pcoddevice) { this.coddevice = pcoddevice; }
        public void addInputPin(pin pp )
        {
            pinInput.Add(pp);
        }
        public void addOutputPin(pin pp)
        {
            pinOutput.Add(pp);
        }
    }
}
