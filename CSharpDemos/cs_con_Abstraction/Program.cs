using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Abstraction
{
    class Abstraction
    {
        abstract class animal
        {
            public abstract void eat();
            public void sound()
            {
                Console.WriteLine("dog barks");
            }
        }
        class dog : animal
        {
            public override void eat()
            {
                Console.WriteLine("dog can eat");
            }
        }
        static void Main(string[] args)
        {
            dog mydog = new dog();
            animal myPet = mydog;
            myPet.eat();
            mydog.sound();
        }
    }
}
