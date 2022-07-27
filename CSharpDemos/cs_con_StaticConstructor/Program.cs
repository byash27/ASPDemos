using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_StaticConstructor
{
    public class Employee
    {
        public int id;
        public String name;
        public static String companyName;
        public Employee(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static Employee()
        {
            companyName = "Birlasoft";
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + companyName);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1452, "Joe");
            Employee e2 = new Employee(2312, "Ben");
            e1.display();
            e2.display();

        }
    }
}
