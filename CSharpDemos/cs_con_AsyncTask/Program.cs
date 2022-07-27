using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_AsyncTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await callMethod();
            Console.ReadKey();
        }

        public static async Task callMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(" Class A");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Class B");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total classes available " + count);
        }
    }
}
