namespace cs_con_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "yash";
            int intStr; bool intResultTryParse = int.TryParse(str, out intStr);
            if (intResultTryParse == true)
            {
                Console.WriteLine(intStr);
            }
            else
            {
                Console.WriteLine("Not in integer format");
            }
        }
    }
}