using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_LambdaArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> mul = (x, y) => x * y;
            Func<int, int, int> div = (x, y) => x / y;

            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine(square.Invoke(a));
            Console.WriteLine(square.Invoke(b));
            Console.WriteLine(mul.Invoke(a, b));
            Console.WriteLine(div.Invoke(a, b));
            Console.ReadKey();
        }
    }
}
