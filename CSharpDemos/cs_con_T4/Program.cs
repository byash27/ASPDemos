using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_T4
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Yash";
            object obj1 = str1;
            string str2 = obj1 as string;

            if (str2 != null)
            {
                Console.WriteLine(" Casted");
            }
            else
            {
                Console.WriteLine("Null String!");
            }


        }
    }
}
