using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Upper2
{
    // Interface
    interface InterfaceExp
    {
        void Conv(string x);
    }


    class Test : InterfaceExp
    {
        public void Conv(string x)
        {

            Console.WriteLine("Converting to uppercase : " + x.ToUpper());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Conv(Console.ReadLine());
        }
    }
}
