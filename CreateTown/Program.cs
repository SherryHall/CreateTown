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
			// Test the House class
			House myHouse = new House("My Castle", "Cinder Block", 3, 2, 3, 1, 10, 4.0, 5.0, 10.0, "305 Elm St", "Apt 3B", "St Pete", "FL", 33715);
			Console.WriteLine($"Type is {myHouse.BuildingType} with height of {myHouse.Height} and width of {myHouse.Width}. volume = {myHouse.Volume}  sqft = {myHouse.SquareFootage}  ");
			Console.WriteLine(myHouse.DisplayName());
			Console.WriteLine(myHouse.ToString());
			Console.WriteLine(myHouse.FullAddress);

			//Test the Bank class
			Bank myBank = new Bank ("Big Bucks Bank", "Glass", 3, 2, 3, 25, 100.0, 25.0, 10.0, "1 Main St", "Ste 505", "St Pete", "FL", 33701);
			Console.WriteLine($"\nType is {myBank.BuildingType} with height of {myBank.Height} and width of {myBank.Width}. volume = {myBank.Volume}  sqft = {myBank.SquareFootage}  ");
			Console.WriteLine(myBank.DisplayName());
			Console.WriteLine(myBank.ToString());
			myBank.DepositMoney(1000.85);
			myBank.WithdrawMoney(310);
			Console.WriteLine (myBank.GetBalance());

			//Test the School class
			School mySchool = new School("Cape Elementary", "Wood", 500, 10, 40, 2, 50, 100.0, 25.0, 10.0, "615 47th St", "Building C", "Cape Coral", "FL", 33904, 16, 6);
			Console.WriteLine($"\nType is {mySchool.BuildingType} with height of {mySchool.Height} and width of {mySchool.Width}. volume = {mySchool.Volume}  sqft = {mySchool.SquareFootage}  ");
			Console.WriteLine(mySchool.DisplayName());
			Console.WriteLine(mySchool.ToString());
			Console.WriteLine(mySchool.TeacherStudentRatio());

			Console.ReadLine();
		}
	}
}
