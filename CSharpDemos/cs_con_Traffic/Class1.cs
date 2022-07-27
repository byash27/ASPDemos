using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal ts = new TrafficSignal();
            ts.IdentifySignal();
            ts.display();
        }
    }
}
