using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(22);
            a1.Add("Yash");
            a1.Add(true);

            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.ReadKey();
        }
    }
}