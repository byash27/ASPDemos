using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>() { new Animal("Animal:Doggy"), new Fish("Fish:Nemo"), new Mammal("Mamal:Algae") };
            OutputAnimalsNames(animals);
        }

        private static void OutputAnimalsNames(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
            {
                
                Console.WriteLine(animal.Name);
                
            }
        }
    }

    public interface IAnimal
    {
        Guid Guid { get; }
  
        string Name { get; }

        
    }

    public class Animal : IAnimal
    {
        public Guid Guid { get; private set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
            this.Guid = Guid.NewGuid();
        }
    }

    public class Fish : Animal
    {
        public Fish(string name) : base(name)
        {

        }
    }

    public class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {

        }
    }

}
