namespace cs_con_1D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] arr;              // Declaring the array
            //    arr = new int[4];       // Declaring size of array
            //    arr[0] = 1;             // Entering members in it
            //    arr[1] = 2;
            //    arr[2] = 3;
            //    arr[3] = 4;

            //    Console.WriteLine("Elements in arr");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($" {arr[i]}");
            //    }
            //    Console.WriteLine();
            //}

            int[,] arr = new int[3, 3];       //declarinf 2D array  
            arr[0, 1] = 22;                   //initialization  
            arr[1, 2] = 24;
            arr[2, 0] = 26;

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
