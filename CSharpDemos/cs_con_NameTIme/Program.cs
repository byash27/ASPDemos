namespace cs_con_NameTIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ur name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            DateTime a = DateTime.Now;
            Console.WriteLine("Today's Date and current time is " + a);
        }
    }
}