namespace cs_con_StrucExp
{
    public struct Student
    {
        public string A;
        public string B;
    }

    class Details
    {
        static void Main(string[] args)
        {
            Student s1;
            s1.A = "Hello";
            s1.B = "World";
            Console.WriteLine("A :" + s1.A + "\nB: "+ s1.B);
        }
    }
}