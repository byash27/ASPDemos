using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calci
{
    public class BasicCalculator
    {

        public delegate double Eg(double first, double last);

        public static double Add(double first, double last)
        {
            return first + last;
        }
        public static double Subtract(double first, double last)
        {
            return first - last;
        }
        public static double Multiply(double first, double last)
        {
            return first * last;
        }
        public static double Divide(double first, double last)
        {
            return first / last;
        }
    }
}
