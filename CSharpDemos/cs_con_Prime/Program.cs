using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int num, i, m = 0, flag = 0;
        Console.Write("Enter the Integer : ");
        num = int.Parse(Console.ReadLine());
        m = num / 2;
        for (i = 2; i <= m; i++)
        {
            if (num % i == 0)
            {
                Console.Write("not Prime.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Prime.");
    }
}