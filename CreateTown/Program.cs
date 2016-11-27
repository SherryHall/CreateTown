using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown
{
	class Program
	{
		static void Main(string[] args)
		{
			House myHouse = new House("My Castle", 3, 2, 3, 1, 10, 4.0, 5.0, 10.0, "1 Main St", "Ste 505", "St Pete", "FL", 33715);
			Console.WriteLine($"Type is {myHouse.BuildingType} with height of {myHouse.Height} and width of {myHouse.Width}. volumn = {myHouse.Volume}  sqft = {myHouse.SquareFootage}  ");
			Console.WriteLine(myHouse.DisplayName());
			Console.WriteLine(myHouse.ToString());
			Console.ReadLine();
		}
	}
}
