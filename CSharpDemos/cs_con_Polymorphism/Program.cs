using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OverridingExample
{
    class Subject            
    {
        public virtual void study()             
        {
            Console.WriteLine("all subjects");
        }
    }
    class Mathematics : Subject    
    {
        public override void study()       
        {
            base.study();
            Console.WriteLine("Mathematics");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.study();
            Console.ReadLine();
        }
    }
}