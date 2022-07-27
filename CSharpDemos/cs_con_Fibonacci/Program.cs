using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace cs_con_Fibonacci
{
    class Program
    {
        private static IEnumerable<int> Fibonacci()
        {
            int prev = 0;
            int current = 1;
            while (true)
            {
                yield return current;
                var next = prev + current;
                prev = current;
                current = next;
            }
        }

        static void Main(String[] args)
        {
            var numbers = Fibonacci().Skip(1).Take(10).ToArray();  // Print first 10 Fibo Nos
            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}