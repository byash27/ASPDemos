using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Encapsulation
{
    public class Bank
    {
        private double balance;
     
        public double getBalance()          // set and get methods
        {
            return balance;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
    }
    class Customer
    {
        public static void Main()
        {
            Bank IQB = new Bank();
            IQB.setBalance(1500);
            Console.WriteLine(IQB.getBalance());
            Console.ReadKey();
        }
    }
}


