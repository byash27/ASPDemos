namespace cs_con_EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem;
            Console.WriteLine("enter the numberr");
            num = Convert.ToInt32(Console.ReadLine());

            rem = num % 2;

            if (rem == 0)
                Console.WriteLine("{0} is  Even", num);
            else
                Console.WriteLine("{0} is Odd", num);
        }
    }
}