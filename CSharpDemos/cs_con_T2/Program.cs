namespace cs_con_T2
{
    public class Student
    {
        public string A;
        public string B;
        public void Details(string A, string B)
        {
            this.A = A;
            this.B = B;
            Console.WriteLine("A is :  " + A + "\n B is : " + B);
        }


        public static void Main(String[] args)
        {
            Student obj = new Student();
            obj.Details("Hello", "World");
        }
    }
}