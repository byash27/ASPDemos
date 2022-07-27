using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Uppercase
{
    interface Demo
    {d
        void function(string a);
    }

    class upper : Demo
    {
        public void function(string a)
        {
            Console.WriteLine(a.ToUpper());
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
             upper obj = new upper();
             obj.function(Console.ReadLine());
        }
    }
}

