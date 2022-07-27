namespace cs_con_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string aValue;

            Console.WriteLine("Enter ur age: ");
            aValue = Console.ReadLine();
            age = int.Parse(aValue);

            Console.WriteLine("Next year you'll be  {0}", ++age);
            Console.Read();
        }
    }
}