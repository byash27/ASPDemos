namespace cs_con_EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            int len = name.Length;

            if (name != "")
            {
                Console.WriteLine("Your Name is " + name);
                Console.WriteLine("Length of String is " + name.Length);
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}