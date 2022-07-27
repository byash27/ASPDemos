using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calculator
{
	public class Calculator
	{
		static void Main(String[] args)
		{
			ProgramName show = new ProgramName("SIMPLE CALCULATOR");
			Console.Write(show.Pname);
			Console.WriteLine("Select the operation ");
			Console.WriteLine(" (+) (-) (*) (/) ");
			Console.WriteLine("Enter operation");
			char Operation = char.Parse(Console.ReadLine());
			info num1 = new info();
			tech num2 = new tech();
			Cal ops = new Cal();
			if (Operation == '+')
			{
				ops.add();
			}
			if (Operation == '-')
			{
				ops.subtract();
			}
			if (Operation == '*')
			{
				ops.multiply();
			}
			if (Operation == '/')
			{
				ops.divide();
			}
		}

		class info
		{
			public double firstnum;

			public double Firstnum
			{
				get { return firstnum; }
				set { firstnum = value; }
			}
			public double method2()
			{
				Console.WriteLine("Enter first No: ");
				Firstnum = Double.Parse(Console.ReadLine());
				return Firstnum;
			}
		}

		class tech
		{
			public double secondnum;

			public double Secondnum
			{
				get { return secondnum; }
				set { secondnum = value; }
			}
			public double method3()
			{
				Console.WriteLine("Enter 2nd Number ");
				Secondnum = Double.Parse(Console.ReadLine());
				return Secondnum;
			}
		}
		
		class ProgramName
        {
			public string Pname;
			public ProgramName(string name)
            {
				Pname = name;
            }
        }
		class Cal
		{
			public double answer;
			info num1 = new info();
			tech num2 = new tech();

			public void add()
			{
				answer = (num1.method2() + num2.method3());
				Console.WriteLine("ANSWER : ");
				Console.WriteLine(answer);
			}

			public void subtract()
			{
				answer = (num1.method2() - num2.method3());
				Console.WriteLine("ANSWER : ");
				Console.WriteLine(answer);
			}

			public void multiply()
			{
				answer = (num1.method2() * num2.method3());
				Console.WriteLine("ANSWER : ");
				Console.WriteLine(answer);
			}

			public void divide()
			{
				answer = (num1.method2() / num2.method3());
				Console.WriteLine("ANSWER : ");
				Console.WriteLine(answer);
			}

		}
	}
}