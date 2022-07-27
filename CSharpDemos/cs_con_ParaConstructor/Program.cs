using System;

class ADD
{
    int x, y;
    double f;
    string s;

    public ADD(int a, double b)
    {
        x = a;
        f = b;
    }

    public ADD(int a, string b)
    {
        y = a;
        s = b;
    }

    public void show()
    {
        Console.WriteLine("constructor A: {0} ", (x + f));
    }

    public void show1()
    {
        Console.WriteLine("constructor  B: {0}",(s + y));
    }
}

class ParaConstructor
{
    static void Main()
    {

 
        ADD a = new ADD(25, 0.5);
        a.show();



        ADD b = new ADD(43, "Marks obtained: ");
        b.show1();
    }
}