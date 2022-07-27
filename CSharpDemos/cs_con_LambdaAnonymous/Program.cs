using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_LambdaAnonymous
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class demo
    {
        static void Main()
        {
            List<People> peoples = new List<People>() {
         new People { Name = "Ram", Age = 24 },
         new People { Name = "Shyam", Age = 10 },
         new People { Name = "Raju", Age = 33 }
      };
            var newPeoplesList = peoples.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            foreach (var item in newPeoplesList)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
