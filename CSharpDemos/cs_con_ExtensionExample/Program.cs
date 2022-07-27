using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ExtensionExample
{
    public static class ExtMetClass
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "27102000";
            int num = str.IntegerExtension();
            Console.WriteLine("Using  extension : {0}", num);
            Console.ReadLine();
        }
    }
}
