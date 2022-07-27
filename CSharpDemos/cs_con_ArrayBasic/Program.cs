namespace cs_con_ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;

            Console.WriteLine("Enter elements of the array : ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}