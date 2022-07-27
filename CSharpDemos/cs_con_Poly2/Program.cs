using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Poly2
{
class Demo
    {
        public int Sum(int x, int y, int z)
        {
            int value = x + y + z;
            return value;
        }
        public double Sum(double x, double y, double z)
        {
            double value = x + y + z;
            return value;
        }
        public static void Main(string[] args) 
        {
            Demo d = new Demo();
            int sum1 = d.Sum(24, 28, 7);
            Console.WriteLine("sum of  two "
            + "integer value : " + sum1);
            double sum2 = d.Sum(10.0, 20.0, 30.0);
            Console.WriteLine("sum of three "
            + "integer value : " + sum2);
          
        }
    }
}
