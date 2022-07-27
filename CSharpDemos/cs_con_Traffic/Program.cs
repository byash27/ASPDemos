using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Traffic
{
public delegate void TrafficDelega();
class TrafficSignal
{
public static void Yellow()
{
Console.WriteLine("Yellow light signals to get ready");
}
public static void Green()
{
Console.WriteLine("Green light signals to go");
}
public static void Red()
{
Console.WriteLine("Red light signals to stop");
}
        TrafficDelega[] traffictd = new TrafficDelega[3];
public void IdentifySignal()
{
            traffictd[0] = new TrafficDelega(Yellow);
            traffictd[1] = new TrafficDelega(Green);
            traffictd[2] = new TrafficDelega(Red);
}
public void display()
{
            traffictd[0]();
            traffictd[1]();
            traffictd[2]();
}
} }
