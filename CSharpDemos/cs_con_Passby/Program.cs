namespace cs_con_Passby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Pass Value");
            i = 22;
            Console.WriteLine($"Before: i = {i}");
            Console.WriteLine("Square Root is :{0}",Math.Sqrt(i));
            PassByValue(i);
            Console.WriteLine($"After: i = {i}");
            Console.WriteLine("Square Root is :{0}", Math.Sqrt(i));
            Console.WriteLine();

            Console.WriteLine("Pass by Reference");
            i = 22;                         
            Console.WriteLine($" Before: i = {i}");
            Console.WriteLine("Square Root is :{0}", Math.Sqrt(i));
            PassByReference(ref i);
            Console.WriteLine($"After: i = {i}");
            Console.WriteLine("Square Root is :{0}", Math.Sqrt(i));
            Console.WriteLine();

            Console.WriteLine("Pass by Out");
            i = 22;                        
            Console.WriteLine($"Before: i = {i}");
            Console.WriteLine("Square Root is :{0}", Math.Sqrt(i));
            PassByOut(out i);
            Console.WriteLine($"After : i = {i}");
            Console.WriteLine("Square Root is :{0}", Math.Sqrt(i));
            Console.WriteLine();
        }
        static void PassByValue(int x)
        {
            Console.WriteLine($"now x = {x}");
            x = 24;
            Console.WriteLine($" after, x = {x}");
        }
        static void PassByReference(ref int x)
        {
            Console.WriteLine($"Before x = {x}");
            x = 24;
            Console.WriteLine($"After , x = {x}");
        }

        static void PassByOut(out int x)
        {
            x = 24;             
            Console.WriteLine($"after performing, x = {x}");
        }

        }
    }
