using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Destructor
{
    public class Car
    {
        int number;
        int val;
        public void valIn(int x, int y)
        {
            number = x;
            val = y;
        }
        public void result()
        {
            Console.WriteLine(number);
            Console.WriteLine(val);
        }
        ~Car()
        {
            Console.WriteLine("Destroyed");
        }
    }

    public class Demo
    {
        public static void Main()
        {
            Car x = new Car();
            x.valIn(23, 32);
            x.result();
        }
    }
}
