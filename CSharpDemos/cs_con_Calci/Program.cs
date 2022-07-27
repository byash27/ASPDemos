using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calci
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator.Eg add = BasicCalculator.Add;
            BasicCalculator.Eg subtract = BasicCalculator.Subtract;
            BasicCalculator.Eg multiply = BasicCalculator.Multiply;
            BasicCalculator.Eg divide = BasicCalculator.Divide;


            Console.WriteLine("Enter First No");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second No");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            double result;


            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("5) Finish");

            
            Boolean run = true;
            do
            {
                Console.Write("Choose Operation:  ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        result = add(FirstNumber, SecondNumber);
                        Console.WriteLine(result);
                        break;

                    case 2:

                        result = subtract(FirstNumber, SecondNumber);
                        Console.WriteLine(result);
                        break;

                    case 3:

                        result = multiply(FirstNumber, SecondNumber);
                        Console.WriteLine(result);
                        break;

                    case 4:
                        result = divide(FirstNumber, SecondNumber);
                        Console.WriteLine(result);
                        break;

                    case 0:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Option");
                        break;
                }
            } while (run == true);

            

        }
    }
}
