using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Aggregation
{
    public class Address
    {
        public string address, city, state;
        public Address(string address, string city, string state)
        {
            this.address = address;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address; 
        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.address + " " + address.city + " " + address.state);
        }
    }
    public class TestAggregation
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("A4, Rose Villa", "Texas", "UK");
            Employee e1 = new Employee(134, "Joe", a1);
            e1.display();
        }
    }
}
