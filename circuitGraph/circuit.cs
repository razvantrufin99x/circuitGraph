using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitGraph
{
    public class circuit
    {
        public int codcircuit;
        public int countwires = 0;
        public int countdevices = 0;
        public ce c = new ce();
        public List<device> devices = new List<device>();
        public List<wire> wires = new List<wire>();
        public circuit() { }
        public circuit(int pcodcircuit) { this.codcircuit = pcodcircuit; }
        public void addDevice(device pd) { devices.Add(pd); }
        public void addWire(wire pw) { wires.Add(pw); }
        public void countAllWires() 
        { 
            countwires = wires.Count;
        }
        public void countAllDevices()
        {
            countdevices  = devices.Count;
        }

    }
}
