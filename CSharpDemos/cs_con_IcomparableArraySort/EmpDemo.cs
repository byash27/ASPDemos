using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IcomparableArraySort
{
    internal class Emp
    {
        static void Main(String[] args)
        {
            Employees[] emp =
            {
                new Employees()
                {
                    EmpId = 121,
                    EmpName = "Root"
                },

                new Employees()
                {
                    EmpId = 202,
                    EmpName = "Ben"
                },

                new Employees()
                {
                    EmpId = 193,
                    EmpName = "Buttler"
                },

                new Employees()
                {
                    EmpId = 224,
                    EmpName = "Jos"
                },

                new Employees()
                {
                    EmpId = 125,
                    EmpName = "Archer"
                },

                new Employees()
                {
                    EmpId = 136,
                    EmpName = "Cook"
                }
            };

            Console.WriteLine("Before Sort");
            foreach (Employees e in emp)
            {
                Console.WriteLine($"{e.EmpId}\t{e.EmpName}");
            }
            Console.WriteLine();

            Array.Sort(emp);
            Console.WriteLine("After Sort");

            foreach (Employees e in emp)
            {
                Console.WriteLine($"{e.EmpId}\t{e.EmpName}");
            }
        }
    }
}
