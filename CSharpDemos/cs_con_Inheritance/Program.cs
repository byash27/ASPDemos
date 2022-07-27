using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Inheritance
{
    class Employee
    {
        int id;
        string name;

        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public String GetName()
        {
            return name;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
    }

    class Manager : Employee
    {
        public double Salary;

        public double GetSalary()
        {
            return Salary;
        }

        public void SetSalary(double Salary)
        {
            this.Salary = Salary;
        }
    }
    class Test
    {
        static void Main(String[] args)
        {
            Manager m = new Manager();
            m.SetId(11);
            m.SetName("Joe");
            m.SetSalary(1234.44);
            Console.WriteLine(m.GetId());
            Console.WriteLine(m.GetName());
            Console.WriteLine(m.GetSalary());
        }
    }
}
