namespace cs_con_Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 12;
            int b = a;

            long x = 121;
            int value = (int)x;
            Console.Write("a: {0}. \nx: {2}, \nvalue: {3}\n", a, b, x, value);
        }
    }
}