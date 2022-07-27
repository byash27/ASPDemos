using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_SortUsingLINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] cars = { "BMW", "Toyoto", "Audi", "KIA", "Tesla", "Range Rover", "Volvo" };

			
			var sortedValuesAsc = from car in cars
								  orderby car
								  select car;

			
			var sortedValuesDesc = from car in cars
								   orderby car descending
								   select car;

			Console.WriteLine("Ascending Order");
			Array.ForEach<string>(sortedValuesAsc.ToArray<string>(), x => Console.WriteLine(x));
			Console.WriteLine();
			Console.WriteLine("Descending Order");
			Array.ForEach<string>(sortedValuesDesc.ToArray<string>(), y => Console.WriteLine(y));
			Console.ReadKey();
		}
	}
}
