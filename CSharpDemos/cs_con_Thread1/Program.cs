using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Thread1
{
    class Iphone
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread begins");

            //creating thread objects
            Thread th1 = new Thread(ListeningMusic);
            Thread th2 = new Thread(ChargingIphone);

            //invoking Threading objects.
            // thread to start listening music task
            th1.Start();

            //thread to start to phone charging.
            th2.Start();
            Console.WriteLine("Main Thread terminates");
        }
        public static void ListeningMusic()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Listening Song " + i);
            }
        }
        public static void ChargingIphone()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Charging done " + i * 10 + " %");
            }
            Console.WriteLine("100 % charging please unplug the charger");
        }
    }
}
